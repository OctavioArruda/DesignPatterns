using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
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
