using Spectre.Console;

namespace StructuralPattern.Structural;

public class Engine
{
    public static void V8() => AnsiConsole.MarkupLine("[green]V8 engine[/]");
}
public class Model
{
    public static void Sedan() => AnsiConsole.MarkupLine("[green]Sedan model[/]");
}
public class Color
{
    public static string Blue() => "[blue]Blue color[/]";
}


public class BmwFacade
{
    private readonly Engine _engine = new();
    private readonly Model _model = new();
    private readonly Color _color = new();

    public void CreateCar()
    {
        AnsiConsole.MarkupLine("\n[green]Creating BMW car...[/]");
        Engine.V8();
        Model.Sedan();
        AnsiConsole.MarkupLine(Color.Blue()); 
    }
}


public abstract class Facade
{
    public static void Run()
    {
        var bmw = new BmwFacade();
        bmw.CreateCar();
    }
}
