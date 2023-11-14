using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Computer
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
}

public class Desktop : Computer
{
}

public class Laptop : Computer
{
}

public class Program
{
    public static void Main()
    {
        List<Computer> computers = new List<Computer>
        {
            new Desktop { Name = "Desktop1", Cost = 1000 },
            new Desktop { Name = "Desktop2", Cost = 1500 },
            new Laptop { Name = "Laptop1", Cost = 2000 },
            new Laptop { Name = "Laptop2", Cost = 2500 }
        };

        var averageCosts = computers
            .GroupBy(c => c.GetType().Name)
            .Select(g => new { Category = g.Key, AverageCost = g.Average(c => c.Cost) });

        foreach (var cost in averageCosts)
        {
            Console.WriteLine($"Средняя стоимость для {cost.Category}: {cost.AverageCost}");
        }
    }
}
