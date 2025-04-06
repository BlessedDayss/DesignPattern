using Spectre.Console;

namespace StructuralPattern.Structural;

public interface IEuroCar
{
    void Display(string car);
}

public class AmericanCar
{
    public static void AmericarCar(string car)
    {
        AnsiConsole.Markup($"\n[green]American car: {car}[/]\n");
    }
}

public class CarAdapter(AmericanCar americanCar) : IEuroCar
{
    public AmericanCar Car { get; } = americanCar;

    public void Display(string car)
    {
        AmericanCar.AmericarCar(car);
    }
}

public abstract class Adapter
{
    public static void Run()
    {
        IEuroCar euroCar = new CarAdapter(new AmericanCar());
        euroCar.Display("Chevrolet Camaro");
    }
}