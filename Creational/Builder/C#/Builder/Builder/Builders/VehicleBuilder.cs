using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    /// <summary>
    /// Director of vehicles - Director of the Builder pattern of this project
    /// </summary>
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(uint seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmision(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }

        public void SetAirbagType(Airbag airbagType)
        {
            vehicle.Airbag = airbagType;
        }
    }
}
