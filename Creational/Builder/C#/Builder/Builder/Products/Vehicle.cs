using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private uint seats;
        private Engine engine;
        private Transmission transmission;
        private Airbag airbags;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public uint Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }

        public Airbag Airbag
        {
            get => airbags;
            set => airbags = value;
        }

    }
}
