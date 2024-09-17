using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Trainer
{
    private Pokeball pokeballinstance = new Pokeball();
    private string nametrainer;
    public List<Pokeball> pokebelt;
    private int amount_pokeballs_trainer = 1;
    private bool has_pokemon = true;
    private Pokemon charmanderinstance = new Charmander("charmander", PokemonTypes.fire, PokemonTypes.water);
    private Pokemon squirtleinstance = new Squirtle("squirtle", PokemonTypes.water, PokemonTypes.grass);
    private Pokemon bulbasaurinstance = new Bulbasaur("bulbasaur", PokemonTypes.grass, PokemonTypes.fire);
    private int randomnumber;
    private int wins = 0;
    public Trainer(String nametrainer, List<Pokeball> pokeBelt)
    {
        this.nametrainer = nametrainer;
        this.pokebelt = pokeBelt;
    }

    public string getName()
    {
        Console.WriteLine("what name do you want to give the trainer?");
        string nametrainer = Console.ReadLine();
        return nametrainer;
    }
    public void setName(string newname)
    {
        this.nametrainer = newname;
    }

    public Pokemon? throwPokeball()
    {
        Random rnd = new Random();
        randomnumber = rnd.Next(1, 4);
        if (randomnumber == 1)
        {
            has_pokemon = true;
            Console.WriteLine(nametrainer + "throws his" + amount_pokeballs_trainer + " pokeball");
            Console.WriteLine(charmanderinstance.doGrowl());
            amount_pokeballs_trainer += 1;
            return charmanderinstance;
        }
        else if (randomnumber == 2)
        {
            has_pokemon = true;
            Console.WriteLine(nametrainer + "throws his" + amount_pokeballs_trainer + " pokeball");
            Console.WriteLine(squirtleinstance.doGrowl());
            amount_pokeballs_trainer += 1;
            return squirtleinstance;
        }
        else if (randomnumber == 3)
        {
            has_pokemon = true;
            Console.WriteLine(nametrainer + "throws his" + amount_pokeballs_trainer + " pokeball");
            Console.WriteLine(bulbasaurinstance.doGrowl());
            amount_pokeballs_trainer += 1;
            return bulbasaurinstance;
        }
        else
        {
            return null;
        }
    }
    public void takePokeball()
    {
        charmanderinstance.doGrowl();
    }
    public void returnPokemon()
    {
        if (randomnumber == 1)
        {
            Console.WriteLine(nametrainer + "'s " + charmanderinstance.getName() + " returns to its pokeball");
        }
        else if (randomnumber == 2)
        {
            Console.WriteLine(nametrainer + "'s " + squirtleinstance.getName() + " returns to its pokeball");
        }
        else if (randomnumber == 3)
        {
            Console.WriteLine(nametrainer + "'s " + bulbasaurinstance.getName() + " returns to its pokeball");
        }
    }
}


