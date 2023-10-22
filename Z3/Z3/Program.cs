// Обобщенный класс для компота
class Compote<T, U>
{
    // Список ингредиентов
    private List<T> ingredientsT;
    private List<U> ingredientsU;

    public Compote(List<T> tIngredients, List<U> uIngredients)
    {
        ingredientsT = tIngredients;
        ingredientsU = uIngredients;
    }

    // Метод для вывода рецепта
    public void PrintRecipe()
    {
        Console.WriteLine("Рецепт компота:");
        Console.WriteLine("Яблоки:");
        foreach (var item in ingredientsT)
        {
            Console.WriteLine($" - {item}");
        }
        Console.WriteLine("Сливы:");
        foreach (var item in ingredientsU)
        {
            Console.WriteLine($" - {item}");
        }
    }
}

// Класс для яблок
class Apple
{
    public int Amount { get; set; }

    public Apple(int amount)
    {
        Amount = amount;
    }

    public override string ToString()
    {
        return $"Яблоко (количество: {Amount})";
    }
}

// Класс для слив
class Plum
{
    public int Amount { get; set; }

    public Plum(int amount)
    {
        PhoneContacts = phoneContacts;
        EmailContacts = emailContacts;
    }

    public override string ToString()
    {
        return $"Слива (количество: {Amount})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Apple> apples = new List<Apple>
        {
            new Apple(3),
            new Apple(2)
        };

        List<Plum> plums = new List<Plum>
        {
            new Plum(4),
            new Plum(5)
        };

        Compote<Apple, Plum> myCompote = new Compote<Apple, Plum>(apples, plums);
        myCompote.PrintRecipe();
    }
}

