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
        Trainer trainer = new Trainer("name", 6);
        Charmander charmander = new Charmander("charmander", "fire", "water");
        Pokeball pokeball = new Pokeball("Charmander", charmander);

        //Player give name to the trainers
        List<string>trainerNames = program.giveNames();
        string trainer1 = trainerNames[0];
        string trainer2 = trainerNames[1];

        List<string> trainer1Belt = trainer.beltContent();
        List<string> trainer2Belt = trainer.beltContent();
        foreach (string pokemon in trainer1Belt) 
        {
            //Pokeball Battle
            trainer.throwPokeball(charmander, pokeball, trainer1, pokemon);
            trainer.throwPokeball(charmander, pokeball, trainer2, pokemon);
            trainer.returnPokeball(charmander, pokeball, trainer1);
            trainer.returnPokeball(charmander, pokeball, trainer2);
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
        this.nickName = "Charmander";
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
    public String pokeballContent;
    public Charmander charmander;

    public Pokeball(String pokeballContent, Charmander charmander)
    {
        this.pokeballContent = "Charmander";
        this.charmander = charmander;
    }
    public void openPokeball(string pokemon)
    {
        Console.WriteLine("Pokeball opens! release " + pokemon);
    }

    public void closePokeball()
    {
        Console.WriteLine("Pokeball closes");
    }
}

//Trainer class
class Trainer
{
    public String name;
    public int amountBelt;

    public Trainer(string name, int amountBelt)
    {
        this.name = name;
        this.amountBelt = 6;
    }

    public List<string> beltContent()
    {
        List<string> beltContent = new List<string>();
        for (int i = 0; i < amountBelt; i++)
        {
            beltContent.Add("Charmander"); 
        }
        return beltContent;
    }

    public void throwPokeball(Charmander charmander, Pokeball pokeball, String name, String pokemon)
    {
        Console.WriteLine(name + " throws a pokeball");
        pokeball.openPokeball(pokemon);
        charmander.battleCry();
    }

    public void returnPokeball(Charmander charmander, Pokeball pokeball, String name)
    {
        Console.WriteLine(name + " returns their " + charmander.nickName);
        pokeball.closePokeball();
    }
}