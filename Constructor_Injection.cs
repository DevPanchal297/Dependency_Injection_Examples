// Constructor Injection example in C#

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
	// Dependencies are declared, but NOT created here
	// They will be provided from the outside (Inversion of Control).
	private readonly Hammer _hammer;
	private readonly Saw _saw;

	// Constructor Injection:
	// Builder requires Hammer and Saw to be passed in
	// The responsibility of creating dependencies is shifted to the caller (Program/Main).
	public Builder(Hammer hammer, Saw saw)
	{
		_hammer = hammer;
		_saw = saw;
	}

	// Method that uses the injected dependencies
	public void BuildHouse()
	{
		_hammer.Use();
		_saw.Use();
		Console.WriteLine("House built (Constructor Injection)!");
	}
}

public class Program
{
	public static void Main()
	{
		// Client code is now responsible for providing dependencies
		// This allows flexibility — we could pass different implementations here.
		Hammer hammer = new Hammer();
		Saw saw = new Saw();

		// Injecting dependencies via constructor
		Builder builder = new Builder(hammer, saw);
		builder.BuildHouse();
	}
}
