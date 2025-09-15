// Interface Injection example in C#

using System;

// Dependency class: Hammer
public class Hammer
{
    public void Use() => Console.WriteLine("Using Hammer");
}

// Dependency class: Saw
public class Saw
{
    public void Use() => Console.WriteLine("Using Saw");
}

// Interface defines how dependencies will be injected
// Any class implementing IToolUser must provide ways to accept Hammer and Saw.
public interface IToolUser
{
    void SetHammer(Hammer hammer);
    void SetSaw(Saw saw);
}

// Consumer class: Builder
// Implements IToolUser interface and receives dependencies via interface methods
public class Builder : IToolUser
{
    private Hammer _hammer;
    private Saw _saw;

    // Interface Injection: dependencies are "injected" through interface methods
    public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(Saw saw)
    {
        _saw = saw;
    }

    // Uses injected dependencies
    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House built (Interface Injection)!");
    }
}

public class Program
{
    public static void Main()
    {
        // Client code provides dependencies via interface-defined methods
        Builder builder = new Builder();
        builder.SetHammer(new Hammer());
        builder.SetSaw(new Saw());

        builder.BuildHouse();
    }
}
