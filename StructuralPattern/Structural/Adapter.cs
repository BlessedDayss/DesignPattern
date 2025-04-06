using Spectre.Console;

namespace StructuralPattern;

public interface IEuroCar
{
    void Display(string car);
}

public class AmericarCar
{
    public void AmericanCar(string car)
    {
        AnsiConsole.Markup($"\n[green]American car: {car}[/]\n");
    }
}

public class CarAdapter : IEuroCar
{
    private readonly AmericarCar _americarCar;
    
    public CarAdapter(AmericarCar americarCar)
    {
        _americarCar = americarCar;
    }
    
    public void Display(string car)
    {
        _americarCar.AmericanCar(car);
    }
}

public abstract class Adapter
{
    public static void Run()
    {
        IEuroCar euroCar;
        euroCar = new CarAdapter(new AmericarCar());
        euroCar.Display("Chevrolet Camaro");
    }
}