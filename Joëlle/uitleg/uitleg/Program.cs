using OOPDemo_Re.classes;

namespace OOPDemo_Re
{
    class MarioKart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Kart customKart = new Kart(80, "soft", "red");
            Console.WriteLine(customKart.color);
            BlueShell shell = new BlueShell("player1", "Blue shell", 1, 100);
        }
    }
}
