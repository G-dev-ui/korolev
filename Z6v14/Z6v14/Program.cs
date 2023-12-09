using System;

public interface ICommand
{
    double Execute(double a, double b);
    double Undo(double a, double b);
}

public class AddCommand : ICommand
{
    public double Execute(double a, double b) => a + b;
    public double Undo(double a, double b) => a - b;
}

public class SubtractCommand : ICommand
{
    public double Execute(double a, double b) => a - b;
    public double Undo(double a, double b) => a + b;
}

public class MultiplyCommand : ICommand
{
    public double Execute(double a, double b) => a * b;
    public double Undo(double a, double b) => a / b;
}

public class DivideCommand : ICommand
{
    public double Execute(double a, double b) => a / b;
    public double Undo(double a, double b) => a * b;
}

public class Program
{
    static void Main(string[] args)
    {
        double a = GetDoubleFromUser("Введите первое число:");
        double b = GetDoubleFromUser("Введите второе число:");

        ICommand command = null;
        while (command == null)
        {
            Console.WriteLine("Выберите действие: 1 - сложить, 2 - вычесть, 3 - умножить, 4 - разделить");
            int action;
            if (!Int32.TryParse(Console.ReadLine(), out action))
            {
                Console.WriteLine("Вы ввели недопустимое число. Пожалуйста, попробуйте еще раз.");
                continue;
            }

            command = action switch
            {
                1 => new AddCommand(),
                2 => new SubtractCommand(),
                3 => new MultiplyCommand(),
                4 => new DivideCommand(),
                _ => null,
            };

            if (command == null)
            {
                Console.WriteLine("Вы выбрали неправильное действие. Пожалуйста, попробуйте еще раз.");
            }
        }

        double result = command.Execute(a, b);
        Console.WriteLine($"Результат: {result}");
    }

    static double GetDoubleFromUser(string prompt)
    {
        double number;
        while (true)
        {
            Console.WriteLine(prompt);
            if (Double.TryParse(Console.ReadLine(), out number))
            {
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели недопустимое число. Пожалуйста, попробуйте еще раз.");
            }
        }
        return number;
    }
}
