using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public List<String> giveNames()
    {
        List<String> names = new List<String>();
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine("Give a name to trainer" + i);
            String name = Console.ReadLine();
            names.Add(name);
        }
        return names;
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        Trainer trainer = new Trainer("name", new List<Pokeball>());
        Charmander charmander = new Charmander("Charmander", "fire", "water");
        Pokeball pokeball = new Pokeball(charmander);

        //Player give name to the trainers
        List<string>trainerNames = program.giveNames();
        string trainerName1 = trainerNames[0];
        string trainerName2 = trainerNames[1];
        Trainer trainer1 = new Trainer(trainerName1, new List<Pokeball>());
        Trainer trainer2 = new Trainer(trainerName2, new List<Pokeball>());

        foreach (Pokeball pokemon in trainer.belt) 
        {
            //Pokeball Battle
            Console.WriteLine(trainerName1 + " throws a pokeball");
            trainer1.throwPokeball();
            charmander.battleCry();
            Console.WriteLine(trainerName2 + " throws a pokeball");
            trainer2.throwPokeball();
            charmander.battleCry();
            trainer.returnPokemon(charmander);
            Console.WriteLine(trainerName1 + " returns their pokeball");
            trainer.returnPokemon(charmander);
            Console.WriteLine(trainerName2 + " returns their pokeball");

            //Player decides whether they keep playing
            Console.WriteLine("Do you want to keep playing? If you want to quit type quit");
            string keepPlaying = Console.ReadLine();
            if (keepPlaying == "quit")
            {
                break;
            }
        }
        Console.WriteLine("Trainers have used all there pokemon");
    }
}

//Charmander class
public class Charmander
{
    public String nickName;
    public String strength;
    public String weakness;

    public Charmander (string nickName, string strength, string weakness)
    {
        this.nickName = nickName;
        this.strength = strength;
        this.weakness = weakness;
    }
    public void setName(String nickName)
    {
        this.nickName = nickName;
    }

    public String getName()
    {
        return this.nickName;
    }

    public void battleCry()
    {
        for(int i = 0;i < 10; i++)
        {
            Charmander charmander = new Charmander(nickName, "fire", "water");
            Console.WriteLine(nickName + "!!!");
        }
    }
}

//Pokeball class
class Pokeball
{
    public Charmander charmander;
    bool isFull = true;

    public Pokeball(Charmander charmander)
    {
        this.charmander = charmander;
    }

    public Charmander openPokeball()
    {
        isFull = false;
        Charmander name = this.charmander;
        Console.WriteLine("Pokeball opens! release " + name.nickName);
        this.charmander = null;

        return name;
    }

    public void closePokeball(Charmander charmander)
    {
        isFull = true;
        Charmander nickName = charmander;
        Console.WriteLine(nickName.nickName + " returns to the pokeball");
        this.charmander = charmander;
    }
}

//Trainer class
class Trainer
{
    public String name;
    public int amountBelt;
    public List<Pokeball> belt;
    public int index;

    public Trainer(string name, List<Pokeball> belt)
    {
        this.name = name;
        this.amountBelt = 6;
        this.belt = beltContent();
        this.index = 0;
    }

    public List<Pokeball> beltContent()
    {
        List<Pokeball> beltContent = new List<Pokeball>();
        for (int i = 0; i < amountBelt; i++)
        {
            Charmander charmander = new Charmander("Charmander", "fire", "water");
            Pokeball pokeball = new Pokeball(charmander);
            beltContent.Add(pokeball);
        }
        return beltContent;
    }

    public void throwPokeball()
    {
        // make use of the pokeballs in the belt. increase the index with each 

        Charmander charmander = new Charmander("Charmander", "fire", "water");
        Pokeball pokeball = new Pokeball(charmander);
        Charmander open = pokeball.openPokeball();
        index++;
    }

    public void returnPokemon(Charmander charmander)
    {
        Pokeball pokeball = new Pokeball(charmander);
        pokeball.closePokeball(charmander);
    }
}