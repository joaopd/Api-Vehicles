using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace QueueProcessor.Controllers
{
    public class QueueProcessor : Controller
    {
        private readonly IConfiguration _configuration;
        public QueueProcessor(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QueueProcessor()
        {
            var factory = new ConnectionFactory()
            {
                HostName = _configuration["RabbitMQConfigurations:HostName"]
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "vehicleQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                 {
                     var body = ea.Body;
                     var message = Encoding.UTF8.GetBytes(body);
                     var vehicle = JsonSerializer.Deserialize<Vehicle>(message);
                     SendMail(vehicle.Email);
                 };
               
                channel.BasicConsume(queue: "vehicleQueue",
                                     autoAck: true,
                                     consumer: consumer);
            }

            string emailDestinatario = Request.Form["txtEmail"];
            return View();
        }
    }
    public class Vehicle
    {
        public string Email { get; set; }
    }
}
