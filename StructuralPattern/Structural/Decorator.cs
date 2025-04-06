using Spectre.Console;

namespace StructuralPattern.Structural;

public interface IBmw
{
    string GetDescription();
    double GetCost();
}

public class BasicBmw : IBmw
{
    public string GetDescription() => "BMW";
    public double GetCost() => 20000;
}

public abstract class BmwDecorator(IBmw bmw) : IBmw
{
    protected readonly IBmw Bmw = bmw;

    public virtual string GetDescription() => Bmw.GetDescription();
    public virtual double GetCost() => Bmw.GetCost();
}

public class PremiumPackage(IBmw bmw) : BmwDecorator(bmw)
{
    public override string GetDescription() => Bmw.GetDescription() + ", Premium";
    public override double GetCost() => Bmw.GetCost() + 5000;
}

public class MPackage(IBmw bmw) : BmwDecorator(bmw)
{
    public override string GetDescription() => Bmw.GetDescription() + ", M Package";
    public override double GetCost() => Bmw.GetCost() + 7000;
}

public abstract class Decorator
{
    public static void Run()
    {
        IBmw bmw = new BasicBmw();
        AnsiConsole.MarkupLine($"\n[green]Description: {bmw.GetDescription()}[/]");
        AnsiConsole.MarkupLine($"\n[green]Cost: {bmw.GetCost()}[/]");

        bmw = new PremiumPackage(bmw);
        AnsiConsole.MarkupLine($"\n[green]Description: {bmw.GetDescription()}[/]");
        AnsiConsole.MarkupLine($"\n[green]Cost: {bmw.GetCost()}[/]");

        bmw = new MPackage(bmw);
        AnsiConsole.MarkupLine($"\n[green]Description: {bmw.GetDescription()}[/]");
        AnsiConsole.MarkupLine($"\n[green]Cost: {bmw.GetCost()}[/]");
    }
}