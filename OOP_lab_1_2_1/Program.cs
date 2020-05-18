using System;

namespace OOP_lab_1_2_1
{
    public class Program
    {
        public static int Parse(int seconds)
        {
            return seconds / 60;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Кiлькiсть повних хвилин, що пройшли з початку доби: {0}", Parse(int.Parse(Console.ReadLine())));
        }
    }
}
