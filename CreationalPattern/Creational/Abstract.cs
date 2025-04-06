using Spectre.Console;

namespace DesignPattern.Creational;

public interface IEngine { void Engine(string engine); }
public interface IModel { void Model(string model); }

public class BmwEngine : IEngine
{
    public void Engine(string engine)
    {
        AnsiConsole.Markup($"\n[green]BMW engine: {engine}[/]\n");
    }
}

public class BmwModel : IModel
{
    public void Model(string model)
    {
        AnsiConsole.Markup($"\n[green]BMW model: {model}[/]\n");
    }
}

public class AudiEngine : IEngine
{
    public void Engine(string engine)
    {
        AnsiConsole.Markup($"\n[green]Audi engine: {engine}[/]\n");
    }
}

public class AudiModel : IModel
{
    public void Model(string model)
    {
        AnsiConsole.Markup($"\n[green]Audi model: {model}[/]\n");
    }
}

public interface ICarFactory
{
    IEngine CreateEngine();
    IModel CreateModel();
}

public class BmwFactory : ICarFactory
{
    public IEngine CreateEngine() => new BmwEngine();
    public IModel CreateModel() => new BmwModel();
}
public class AudiFactory : ICarFactory
{
    public IEngine CreateEngine() => new AudiEngine();
    public IModel CreateModel() => new AudiModel();
}

public class CarFactory(ICarFactory carFactory)
{
    public IEngine Engine { get; } = carFactory.CreateEngine();
    public IModel Model { get; } = carFactory.CreateModel();
}

public static class Configuration
{
    public static readonly string CurrentCar = "BMW";
}

public abstract class AbstractFactory
{
    public static void Run()
    {
        ICarFactory carFactory = Configuration.CurrentCar switch
        {
            "BMW" => new BmwFactory(),
            "Audi" => new AudiFactory(),
            _ => throw new NotSupportedException("Car not supported")
        };

        var engine = carFactory.CreateEngine();
        engine.Engine("V8");
        var model = carFactory.CreateModel();
        model.Model("Premium");
    }
}