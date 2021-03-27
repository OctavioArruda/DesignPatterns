namespace FactoryMethod
{
    class MotorcycleFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
