using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

      
        Cat cat = new Cat("Мурка", "простуда", "сіамська");
        cat.ShowInfo();
        cat.Speak();
        cat.AnalyzeDisease("тяжка");

        Console.WriteLine("-------------------------------");

        Dog dog = new Dog("Шарик", "алергія", "середня");
        dog.ShowInfo();
        dog.Speak();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
