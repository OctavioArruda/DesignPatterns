namespace FactoryMethod
{
    // Car factory
    class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }

    }
}
