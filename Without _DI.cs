// Wihthout Dependency Injection (DI) example in C#

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
    // Dependencies (Hammer and Saw) are created INSIDE the Builder class
    // This makes Builder tightly coupled to these concrete implementations.
    private Hammer _hammer;
    private Saw _saw;

    // Constructor: Builder is directly responsible for creating its dependencies
    public Builder()
    {
        // Tightly coupled: Builder decides WHICH dependencies to use
        _hammer = new Hammer();
        _saw = new Saw();
    }

    // Method that uses the dependencies
    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House built (without DI)!");
    }
}

public class Program
{
    public static void Main()
    {
        // Client code
        // Builder creates its own Hammer and Saw internally
        // We (the caller) cannot control or replace dependencies (e.g., with a mock tool)
        Builder builder = new Builder();
        builder.BuildHouse();
    }
}
