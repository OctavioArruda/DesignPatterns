namespace FactoryMethod
{
    /// <summary>
    /// Main interface which is common to all objects that can be produced
    /// by the creator and its subclasses
    /// </summary>
    interface IVehicle
    {
        void StartRoute();
        void GetCargo();
    }
}
