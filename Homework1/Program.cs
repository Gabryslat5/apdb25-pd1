using Homework1;

class Program
{
    public static void Main(string[] args)
    {
        var ship1 = new Ship(60, 100, 100);
        var ship2 = new Ship(100, 100, 100);
        
        // 1. Stworzenie kontenera danego typu
        var liquidContainer = new LiquidsContainer(500, 502, 200, 5000, true);
        var gasContainer = new GasContainer(500, 502, 200, 5000, 10);
        var freezingContainer = new FreezingContainer(500, 502, 200, 5000, "Bananas", -13.3);

        // 2. Załadowanie ładunku do danego kontenera
        liquidContainer.LoadContainer(500);
        gasContainer.LoadContainer(500);
        freezingContainer.LoadContainer(500);
        
        // 3. Załadowanie kontenera na statek
        ship1.LoadContainer(liquidContainer);
        
        // 4. Załadowanie listy kontenerów na statek
        Container[] containers = {gasContainer, freezingContainer };
        ship1.LoadContainers(containers);
        
        // 5. Usunięcie kontenera ze statku
        Console.WriteLine("test: 1. 2. 3. 4. 5.");
        ship1.RemoveContainer("KON-C-3");
        ship1.PrintShipInfo();
        Console.WriteLine();
        
        // 6. Rozładowanie kontenera
        Console.WriteLine("test: 6.");
        freezingContainer.PrintContainerInfo();
        freezingContainer.UnloadContainer();
        freezingContainer.PrintContainerInfo();
        Console.WriteLine();
        
        // 7. Zastąpienie kontenera na statku o danym numerze innym kontenerem
        Console.WriteLine("test: 7.");
        ship1.PrintShipInfo();
        ship1.ReplaceContainer("KON-L-1", freezingContainer);
        ship1.PrintShipInfo();
        Console.WriteLine();
        
        // 8. Możliwość przeniesienie kontenera między dwoma statkami
        Console.WriteLine("test: 8.");
        ship2.PrintShipInfo();
        ship1.MoveCointainer("KON-C-3", ship2);
        ship2.PrintShipInfo();
        Console.WriteLine();
        
        // 9. Wypisanie informacji o danym kontenerze
        Console.WriteLine("test: 9.");
        gasContainer.PrintContainerInfo();
        Console.WriteLine();
        
        // 10. Wypisanie informacji o danym statku i jego ładunku
        Console.WriteLine("test: 10.");
        ship1.PrintShipInfo();
        Console.WriteLine();
        
    }
}
