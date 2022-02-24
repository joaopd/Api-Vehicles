using Domain.Enums;

namespace Domain.Entities
{
    public class Vehicle : BaseEntity
    {

        public string Renavan { get; private set; }
        public string Model { get; private set; }
        public string YearOfManufacture { get; private set; }
        public string YearModel { get; private set; }
        public string Mileage { get; private set; }
        public VehicleStatusEnum Status { get; private set; }
        public decimal Value { get; private set; }
        public Owner Owner { get; private set; }
        public Brand Brand { get; private set; }
        private Vehicle() { }
        public Vehicle(string renavan, string model, string yearOfManufacture, string yearModel, string mileage, VehicleStatusEnum status, decimal value)
        {
            Renavan = renavan;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            YearModel = yearModel;
            Mileage = mileage;
            Status = status;
            Value = value;
        }

        public void SetBrand(Brand brand)
        {
            Brand = brand;
        }

        public void SetOwner(Owner owner)
        {
            Owner = owner;
        }
    }
}
