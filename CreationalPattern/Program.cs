using DesignPattern.Creational;
using Spectre.Console;

namespace DesignPattern;

public class Program
{
    public static void Main()
    {
        AnsiConsole.Markup("[red]Design Pattern - Singleton[/]:");
        SingletonDispatchRoom.Application.Run();
        
        AnsiConsole.Markup("\n[red]Design Pattern - Factory[/]:\n");
        Factory.Run();
        
        AnsiConsole.Markup("\n[red]Design Pattern - Abstract Factory[/]:\n");
        AbstractFactory.Run();
    }
}