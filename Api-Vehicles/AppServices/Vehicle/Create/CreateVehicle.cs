using AppServices.Vehicle.Create;
using AppServices.Vehicle.Create.ViewModels;
using Domain.UoW;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
namespace AppServices.Vehicle
{
    public class CreateVehicle : ICreateVehicle
    {
        private readonly IUnitOfWork _uow;
        private readonly RabbitMQConfigurations _configurations;
        public CreateVehicle(IUnitOfWork uow, RabbitMQConfigurations configurations)
        {
            _configurations = configurations;
            _uow = uow;
        }

        public async Task<Guid> Execute(CreateVehicleViewModel create)
        {
            try
            {
                Domain.Entities.Vehicle vehicle = create;

                vehicle.SetOwnerId(create.OwnerId);
                vehicle.SetBrandId(create.BrandId);

                var response = await _uow.VehicleRepository.Create(vehicle);

                var getOwner = await _uow.OwnerRepository.GetById(create.OwnerId);
                if (getOwner == null)
                    throw new ArgumentNullException("Bad Request");

                var createDispather = new CreateVehicleDispather { EmailOwner = getOwner.Email, Id = vehicle.Id };
                var factory = new ConnectionFactory()
                {
                    HostName = _configurations.HostName
                };

                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "vehicleQueue",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);


                    string message = JsonSerializer.Serialize(createDispather);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                        routingKey: "vehicleQueue",
                                        basicProperties: null,
                                        body: body);
                }

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
