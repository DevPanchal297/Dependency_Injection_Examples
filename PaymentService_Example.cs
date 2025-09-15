using System;

// Logger interface
public interface ILogger
{
    void Log(string message);
}

// Different loggers
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[FileLogger] {message}");
    }
}

public class DbLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[DbLogger] {message}");
    }
}

public class CloudLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[CloudLogger] {message}");
    }
}

// PaymentService depends on ILogger
public class PaymentService
{
    private readonly ILogger _logger;

    // Constructor Injection
    public PaymentService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessPayment(decimal amount)
    {
        _logger.Log($"Processing payment of {amount:C}");
        Console.WriteLine("Payment processed successfully ✅");
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Swap logger easily without changing PaymentService
        ILogger logger = new FileLogger(); 
        // ILogger logger = new DbLogger();
        // ILogger logger = new CloudLogger();

        var paymentService = new PaymentService(logger);
        paymentService.ProcessPayment(1500.00m);
    }
}
