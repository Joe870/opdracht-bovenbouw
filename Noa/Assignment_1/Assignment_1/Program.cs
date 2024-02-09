using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Player give name to charmander
        Console.WriteLine("Give a name to your charmander");
        var nickName = Console.ReadLine();
        //Charmander does battleCry 10 times
        while (true){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nickName + "!!!");
            }
            //Player decides whether they keep playing
            Console.WriteLine("Give your charmander a name. If you want to quit type quit");
            nickName = Console.ReadLine();
            if (nickName == "quit")
            {
                break;
            }
        }
    }
}

//Create Charmander class
class Charmander
{
    public String nickName;
    public String strength;
    public String weakness;

    public Charmander (string nickName, string strength, string weakness)
    {
        this.nickName = nickName;
        this.strength = "fire";
        this.weakness = "water";
    }
    public void setName(String nickName)
    {
        this.nickName = nickName;
    }

    public String getName()
    {
        return this.nickName;
    }

    public void battleCry(String nickName)
    {
        Console.WriteLine(nickName + "!!!");
    }
}