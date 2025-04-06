using Spectre.Console;

namespace DesignPattern.Creational;

public interface IBmwCar
{
    void Car(string car);
}

public class Bmwm : IBmwCar
{
    public void Car(string car)
    {
        AnsiConsole.Markup($"\n[green]BMW model M: {car}[/]\n");
    }
}

public class Bmw : IBmwCar
{
    public void Car(string car)
    {
        AnsiConsole.Markup($"\n[green]BMW: {car}[/]\n");
    }
}

public abstract class CarProduction
{
    public void CarCreation(string car)
    {
         IBmwCar bmw = CreateCar();
         bmw.Car(car);
    }

    protected abstract IBmwCar CreateCar();
}

public class BmwmCreation : CarProduction
{
    protected override Bmwm CreateCar()
    {
        AnsiConsole.Markup("Creating BMW model M...\n");
        return new Bmwm();
    }
}

public class BmwCreation : CarProduction
{
    protected override Bmw CreateCar()
    {
        AnsiConsole.Markup("Creating BMW...\n");
        return new Bmw();
    }
}


public abstract class Factory
{
    public static void Run()
    {   
        CarProduction bmwM = new BmwmCreation();
        
        CarProduction bmw = new BmwCreation();
        
        bmw.CarCreation("BMW 3 Series");
        bmwM.CarCreation("BMW M3");
    }
}