using System;

namespace FactoryMethod
{
    /// <summary>
    /// Different implementations of the product interface
    /// </summary>
    class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando a entrega com motocicleta.");
            GetCargo();
        }
    }
}
