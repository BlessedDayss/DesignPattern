using Spectre.Console;
using StructuralPattern.Structural;

namespace StructuralPattern;

public static class ProgramStuctural
{
    public static void Main()
    {
        AnsiConsole.Markup("[red]Design Pattern - Adapter[/]:\n");
        Adapter.Run();
        
        AnsiConsole.Markup("\n[red]Design Pattern - Facade[/]:\n");
        Facade.Run();
        
        AnsiConsole.Markup("\n[red]Design Pattern - Decorator[/]:\n");
        Decorator.Run();
    }
}