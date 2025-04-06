using Spectre.Console;

namespace DesignPattern.Creational;

public sealed class SingletonDispatchRoom
{
    private static readonly Lazy<SingletonDispatchRoom> DispatchRoomInstance = new(() => new SingletonDispatchRoom());
    
    private readonly List<string> _dispatchRoomMessages = [];

    private static SingletonDispatchRoom Instance => DispatchRoomInstance.Value;

    private void Message(string message)
    {
        _dispatchRoomMessages.Add(message);
        AnsiConsole.Markup($"\n[green]Message from dispatch room: {message}[/]\n");
    }
    
    public class Application
    {
        public static void Run()
        {
            SingletonDispatchRoom dispatchRoom = Instance;
            dispatchRoom.Message("Hello, A380!");
        }
    }
    
}