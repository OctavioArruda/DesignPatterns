using System;

namespace FactoryMethod
{
    /// <summary>
    /// Different implementations of the product interface
    /// </summary>
    class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando o trajeto.");
            GetCargo();
        }
    }
}
