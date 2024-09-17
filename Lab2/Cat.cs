
using System.Xml.Linq;
using System;

public class Cat : Animal
{
    private string breed;

    public string Breed
    {
        get => breed;
        set => breed = value;
    }

    public Cat(string name, string disease, string breed) : base(name, disease)
    {
        this.breed = breed;
    }

    public override void Speak()
    {
        Console.WriteLine($"{name} мявкає.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Ця кішка {breed}. Її звуть {name}.");
    }

    public void AnalyzeDisease(string severity)
    {
        switch (severity.ToLower())
        {
            case "тяжка":
                Console.WriteLine("Хвороба тяжка. Потрібна операція.");
                break;
            case "середня":
                Console.WriteLine("Хвороба середня. Потрібно лікування у клініці.");
                break;
            case "легка":
                Console.WriteLine("Хвороба легка. Лікуйте кішку дома.");
                break;
            default:
                Console.WriteLine("Помилка. Введіть правильно ступінь хвороби.");
                break;
        }
    }
}
