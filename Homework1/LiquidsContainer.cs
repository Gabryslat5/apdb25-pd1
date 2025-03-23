namespace Homework1;

class LiquidsContainer : Container, IHazardNotifier
{
    private bool isHazardous;

    public LiquidsContainer(double height, double ownMass, double depth, double maxLoadMass, bool isHazardous) : base("L", height, ownMass, depth, maxLoadMass)
    {
        this.isHazardous = isHazardous;
    }

    public override void LoadContainer(double mass)
    {
        double maxCapacity = isHazardous ? MaxLoadMass * 0.5 : MaxLoadMass * 0.9;
        if (mass > maxCapacity)
        {
            NotifyHazard("Overfill");
            throw new Exception("OverfillException");
        }
        LoadMass = mass;
    }
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Alert from {SerialNumber}: {message}");
    }
}