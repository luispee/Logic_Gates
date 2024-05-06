using Library;
namespace Program;
class Program
{
    static void Main(string[] args)
    {
        bool a = true;
        bool b = true;
        bool c = false;
        
        GarageGate gate = new GarageGate(a, b, c);

        Console.WriteLine($"{gate.OpenDoor()}");
    }
}
