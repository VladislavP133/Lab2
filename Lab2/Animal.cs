using System;

public abstract class Animal
{
    protected string name;
    protected string disease;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Disease
    {
        get => disease;
        set => disease = value;
    }

    public Animal(string name, string disease)
    {
        this.name = name;
        this.disease = disease;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{name} говорить щось.");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Ця тварина звуть {name}.");
    }
}
