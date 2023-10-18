using System;
using System.Collections.Generic;
using System.Linq;

// Базовый класс "Одежда"
class Clothing
{
    public string Material { get; set; }
    public decimal Cost { get; set; }
    public string Size { get; set; }
}

// Класс "Брюки" наследует от "Одежда"
class Pants : Clothing
{
    public Pants(string material, decimal cost, string size)
    {
        Material = material;
        Cost = cost;
        Size = size;
    }
}

// Класс "Рубашка" наследует от "Одежда"
class Shirt : Clothing
{
    public int SleeveLength { get; set; }

    public Shirt(int sleeveLength, decimal cost, string size)
    {
        SleeveLength = sleeveLength;
        Cost = cost;
        Size = size;
    }
}

// Класс "Список одежды" для хранения коллекции элементов одежды
class ClothingList
{
    private List<Clothing> clothes;

    public ClothingList()
    {
        clothes = new List<Clothing>();
    }

    public void AddClothing(Clothing item)
    {
        clothes.Add(item);
    }

    // Метод для определения суммарной стоимости всех вещей размера S
    public decimal CalculateTotalCostBySize(string size)
    {
        return clothes.Where(c => c.Size == size).Sum(c => c.Cost);
    }

    // Метод для определения средней стоимости рубашек
    public decimal CalculateAverageShirtCost()
    {
        var shirts = clothes.OfType<Shirt>();
        if (shirts.Any())
        {
            return shirts.Average(s => s.Cost);
        }
        return 0;
    }
}

