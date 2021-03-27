using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = ProccessInput(args);
            CheckTranport(transport);
            Console.ReadLine();
        }

        static Transport ProccessInput(string[] input)
        {
            Transport transport = null;

            if (IsUber(input))
            {
                transport = new CarTransport();
            }
            else if (isUberEats(input))
            {
                transport = new MotorcycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo da entrega.");
            }

            return transport;
        }

        #region Checking

        static bool ExistsArgs(string[] args)
        {
            return args.Length > 0;
        }

        static bool IsUber(string[] args)
        {
            return ExistsArgs(args) && args[0] == "--uber";
        }

        static bool isUberEats(string[] args)
        {
            return ExistsArgs(args) && args[0] == "--log";
        }

        static void CheckTranport(Transport transport)
        {
            if (transport != null)
            {
                transport.StartTransport();
            }
        }

        #endregion
    }
}
