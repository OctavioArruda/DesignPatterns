using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Different implementations of the product interface
    /// </summary>
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda.");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando a entrega com bicicleta.");
        }
    }
}
