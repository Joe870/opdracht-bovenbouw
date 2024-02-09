using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Player give name to the trainers
        Trainer trainer = new Trainer("name", 6);
        trainer.giveNames();

        //Pokemon Battle
        while (true){
            Charmander charmander = new Charmander("Charmander", "fire", "water");
            charmander.charmanderHypeUp();
            //Player decides whether they keep playing
            Console.WriteLine("Give your charmander a name. If you want to quit type quit");
        }
    }
}

//Create Charmander class
public class Charmander
{
    public String nickName;
    public String strength;
    public String weakness;

    public Charmander (string nickName, string strength, string weakness)
    {
        this.nickName = "charmander";
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

    public void charmanderHypeUp()
    {
        for(int i = 0;i < 10; i++)
        {
            Charmander charmander = new Charmander(nickName, "fire", "water");
            charmander.battleCry();
        }
    }

    public void battleCry()
    {
        Console.WriteLine(nickName + "!!!");
    }
}

//Create a pokeball class
class Pokeball
{
    //The pokeball is empty or it can contain a single charmander.
    //The pokeball can be thrown, which opens it up, and then releases the charmander inside of it.
    //The charmander can be returned back to its pokeball, which closes the pokeball again.
    public void throwPokeball()
    {
        Console.WriteLine("(name_trainer) throws their pokeball. They release (pokemon name)");
        //Release battle cry
    }

    public void returnPokeball()
    {
        Console.WriteLine("(pokemon name) return to their pokeball");
    }
}

//Create Trainer class
class Trainer
{
    public String name;
    public int amountBelt;

    public Trainer(string name, int amountBelt)
    {
        this.name = name;
        this.amountBelt = 6;
    }

    public List<String> giveNames()
    {
        List<String> names = new List<String>();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Give a name to trainer" + i);
            String name = Console.ReadLine();
            names.Add(name);
        }
        return names;
    }
    public void beltContent()
    {
        List<string> beltContent = new List<string>();
        for (int i = 0; i < amountBelt; i++)
        {
            beltContent.Add("Pokebal" + i); 
        }
    }
}