using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(uint seats);
        void SetEngine(Engine engine);
        void SetTransmision(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbagType(Airbag airbagType);
    }
}
