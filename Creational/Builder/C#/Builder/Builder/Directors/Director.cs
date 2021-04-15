using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    class Director
    {
        IBuilder _builder;

        public Director(IBuilder builder)
        {
            this._builder = builder;
        }

        public void ConstructSedanCar()
        {
            _builder.SetVehicleType(VehicleType.SEDAN);
            _builder.SetEngine(new Engine(2000));
            _builder.SetSeats(5);
            _builder.SetTransmision(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetEngine(new Engine(4000));
            _builder.SetSeats(2);
            _builder.SetTransmision(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            _builder.SetVehicleType(VehicleType.SUV);
            _builder.SetEngine(new Engine(2600));
            _builder.SetSeats(5);
            _builder.SetAirbagType(Airbag.FRONTAL);
            _builder.SetTransmision(Transmission.AUTOMATIC_SEQUENTIAL);
        }
    }
}
