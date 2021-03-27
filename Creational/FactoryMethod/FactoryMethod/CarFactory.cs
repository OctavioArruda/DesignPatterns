namespace FactoryMethod
{
    class CarFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }

    }
}
