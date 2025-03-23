namespace Homework1;

public abstract class Container
{
    private static int counter = 1;
    public string SerialNumber { get; private set; }
    public double LoadMass { get; protected set; }
    public double Height { get; protected set; }
    public double OwnMass { get; protected set; }
    public double Depth { get; protected set; }
    public double MaxLoadMass { get; protected set; }

    public Container(string type, double height, double ownMass, double depth, double maxLoadMass)
    {
        SerialNumber = $"KON-{type}-{counter++}";
        Height = height;
        OwnMass = ownMass;
        Depth = depth;
        MaxLoadMass = maxLoadMass;
    }

    public abstract void LoadContainer(double mass);
    
    public void UnloadContainer()
    {
        LoadMass = 0;
    }
    public void PrintContainerInfo()
    {
        Console.WriteLine($"{SerialNumber}, {LoadMass}kg / {MaxLoadMass}kg");
    }
}