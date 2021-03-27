using System;

namespace FactoryMethod
{
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
