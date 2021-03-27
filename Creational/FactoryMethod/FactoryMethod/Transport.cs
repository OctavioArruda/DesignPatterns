namespace FactoryMethod
{
    /// <summary>
    /// The Creator class that declares the factory method that returns
    /// new products objects. It's important that the return type of 
    /// this method matches the product interface
    /// </summary>
    abstract class Transport
    {
        public void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();

        /* Notwithstanding its name, product creation is NOT the primary responsibility
         * of the creator. Usually, the creator class already has some core business
         * logic related to products. The factory method helps to decouple this logic 
         * from the concrete product classes
         */
    }
}
