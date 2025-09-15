// Setter Injection Example in C#

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

// Consumer class: Builder
public class Builder
{
    // Dependencies are exposed as public properties
    // They will be set (injected) from outside, instead of being created inside.
    public Hammer Hammer { get; set; }
    public Saw Saw { get; set; }

    // Method that uses the injected dependencies
    public void BuildHouse()
    {
        // Using dependencies provided externally
        Hammer.Use();
        Saw.Use();
        Console.WriteLine("House built (Setter Injection)!");
    }
}

public class Program
{
    public static void Main()
    {
        // Client code creates dependencies
        // and assigns them to the Builder’s public properties (Setter Injection).
        Builder builder = new Builder();
        builder.Hammer = new Hammer();
        builder.Saw = new Saw();

        builder.BuildHouse();
    }
}
