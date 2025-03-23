namespace Homework1;

class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; private set; }

    public GasContainer(double height, double ownMass, double depth, double maxLoadMass, double pressure)
        : base("G", height, ownMass, depth, maxLoadMass)
    {
        Pressure = pressure;
    }

    public override void LoadContainer(double mass)
    {
        if (mass > MaxLoadMass)
        {
            NotifyHazard("Overfill");
            throw new Exception("OverfillException");
        }
        LoadMass = mass;
    }

    public void UnloadCargo()
    {
        LoadMass *= 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Alert from {SerialNumber}: {message}");
    }
}