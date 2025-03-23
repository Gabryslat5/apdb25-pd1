namespace Homework1;

public class Ship
{
    public double ContainersWeight { get; private set; }
    public List<Container> Containers { get; private set; }
    public double MaxSpeed { get; private set; }
    public int MaxContainersNumber { get; private set; }
    public double MaxWeight { get; private set; }
    
    public Ship(double maxSpeed, int maxContainersNumber, double maxWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainersNumber = maxContainersNumber;
        MaxWeight = maxWeight;
    }
    public void LoadContainer(Container container)
    {
        ContainersWeight += container.OwnMass + container.LoadMass;
        if (Containers.Count >= MaxContainersNumber)
            throw new Exception("Overfill containers");
        if (ContainersWeight > MaxWeight*1000)
            throw new Exception("Overfill weight");
        Containers.Add(container);
    }

    public void LoadContainers(Container[] containers)
    {
        foreach (var container in containers)
        {
            ContainersWeight += container.OwnMass + container.LoadMass;
        }
        if (Containers.Count >= MaxContainersNumber)
            throw new Exception("Overfill containers");
        if (ContainersWeight > MaxWeight*1000)
            throw new Exception("Overfill weight");
        Containers.AddRange(containers);
    }
    public void RemoveContainer(string serialNumber)
    {
        Container Container = Containers.Find(c => c.SerialNumber == serialNumber);
        ContainersWeight -= Container.OwnMass + Container.LoadMass;
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }
    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        RemoveContainer(serialNumber);
        LoadContainer(newContainer);
    }
    public void MoveCointainer(string serialNumber, Ship newShip)
    {
        Container RemovedContainer = Containers.Find(c => c.SerialNumber == serialNumber);
        RemoveContainer(serialNumber);
        newShip.LoadContainer(RemovedContainer);
    }
    public void PrintShipInfo()
    {
        Console.WriteLine($"Ship weight: {ContainersWeight}kg / {MaxWeight*1000}kg, Ship containers: {Containers.Count} / {MaxContainersNumber}");
        for (int i = 0; i < Containers.Count; i++)
        {
            Container container = Containers[i];
            container.PrintContainerInfo();
        }
    }
}