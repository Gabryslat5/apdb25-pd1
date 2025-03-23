namespace Homework1;

class FreezingContainer : Container
{
    public string ProductType { get; private set; }
    public double Temperature { get; private set; }
    private static Dictionary<string, double> ProductsAndTemperatures = new()
    {
        {"Bananas", -13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.2},
        {"Sausages", 5},
        {"Butter", 20.5},
        {"Eggs", 19}
    };

    public FreezingContainer(double height, double ownMass, double depth, double maxLoadMass, string productType, double temperature)
        : base("C", height, ownMass, depth, maxLoadMass)
    {
        if (!ProductsAndTemperatures.ContainsKey(productType))
            throw new Exception("Invalid product");
        if (temperature < ProductsAndTemperatures[productType])
            throw new Exception("Temperature too low");
        if (temperature > ProductsAndTemperatures[productType])
            throw new Exception("Temperature too high");
        
        ProductType = productType;
        Temperature = temperature;
    }

    public override void LoadContainer(double mass)
    {
        if (mass > MaxLoadMass)
        {
            throw new Exception("OverfillException");
        }
        LoadMass = mass;
    }
}
