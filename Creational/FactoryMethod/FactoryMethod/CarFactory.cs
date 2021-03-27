namespace FactoryMethod
{
    class CarFactory : Transport
    {
        /// <summary>
        /// Concrete Creators override the base factory method so it returns
        /// a different type of product.
        /// </summary>
        /// <returns>A new type of product</returns>
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }

        /* Note that the factory method doesn’t have to 
         * create new instances all the time. It can also
         * return existing objects from a cache, an object pool, or another source.
         */
    }
}
