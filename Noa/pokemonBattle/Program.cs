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
        Trainer trainer = new Trainer("name", 6, new List<string>());
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
            Console.WriteLine(trainer1 + " throws a pokeball");
            trainer.throwPokeball(pokeball);
            charmander.battleCry();
            Console.WriteLine(trainer2 + " throws a pokeball");
            trainer.throwPokeball(pokeball);
            charmander.battleCry();
            trainer.returnPokemon(pokeball, trainer1);
            trainer.returnPokemon(pokeball, trainer2);

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
    bool fullOrEmpty;
    // boolean to know if a pokeball is empty or full

    public Pokeball(String pokeballContent, Charmander charmander)
    {
        this.pokeballContent = "Charmander";
        this.charmander = charmander;
    }
    public String openPokeball(string pokemon)
    {
        // empty
        Console.WriteLine("Pokeball opens! release " + pokemon);
        return pokemon;
    }

    public void closePokeball()
    {
        // full
        Console.WriteLine("Pokeball closes");
    }
}

//Trainer class
class Trainer
{
    public String name;
    public int amountBelt;
    public List<String> belt;

    public Trainer(string name, int amountBelt, List<String> belt)
    {
        this.name = name;
        this.amountBelt = 6;
        this.belt = beltContent();
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

    // Charmander throwPokeball() 
    public String throwPokeball(Pokeball pokeball)
    {
        string charmander = pokeball.openPokeball(belt[0]);

        return charmander;
    }

    // returnPokemon(Charmander charmander)
    public void returnPokemon(Pokeball pokeball, String name)
    {
        Console.WriteLine(name + " returns their " + belt[0]);
        pokeball.closePokeball();
    }
}