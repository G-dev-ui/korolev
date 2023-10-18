public class Ingredient
{
    public string Name { get; set; }
}

public class Apple : Ingredient
{
    public int Quantity { get; set; }
}

public class Plum : Ingredient
{
    public int Quantity { get; set; }
}
//обобщенный класс
public class Compote<T> where T : Ingredient
{
    public List<T> Ingredients { get; set; }

    public Compote(List<T> ingredients)
    {
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine(ingredient.Name);
        }
    }
}
