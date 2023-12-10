using System;
using System.IO;

public class TooShortStringException : Exception
{
    public TooShortStringException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = null;
        try
        {
            Console.Write("Введите имя файла: ");
            string filename = Console.ReadLine();

            Console.Write("Введите строку для записи: ");
            string input = Console.ReadLine();

            if (input.Length < 3)
            {
                throw new TooShortStringException("Строка слишком мала");
            }

            sw = new StreamWriter(filename);
            sw.Write(input[2]);
        }
        catch (TooShortStringException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Неизвестная ошибка: " + ex.Message);
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
            }
        }
    }
}
