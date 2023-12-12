// Обобщенный класс для компота
class Compote<T, U>
{
    // Список ингредиентов
    private List<T> ingredientsT;
    private List<U> ingredientsU;

{
}

{
}
{

    {
    {
    }

    {
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
    {
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

