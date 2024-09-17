
using System.Runtime.Remoting.Lifetime;
using System.Xml.Linq;
using System;

public class Dog : Animal
{
    private string severity;

    public string Severity
    {
        get => severity;
        set => severity = value;
    }

    public Dog(string name, string disease, string severity) : base(name, disease)
    {
        this.severity = severity;
    }

    public override void Speak()
    {
        Console.WriteLine($"{name} гавкає.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Ця собака звуть {name} і має хворобу {disease} з тяжкістю {severity}.");
    }
}
