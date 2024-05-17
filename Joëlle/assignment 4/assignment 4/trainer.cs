using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Trainer
{
    Pokeball pokeballinstance = new Pokeball();
    public string nametrainer;
    public List<Pokeball>? pokebelt;
    public int amount_pokeballs_trainer = 1;
    public bool has_pokemon = true;
    public Pokemon charmanderinstance = new Charmander("charmander", "fire", "water");
    public Pokemon squirtleinstance = new Squirtle("squirtle", "water", "grass");
    public Pokemon bulbasaurinstance = new Bulbasaur("bulbasaur", "grass", "fire");
    private int randomnumber;
    public int wins = 0;
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

    public Pokemon throwPokeball()
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
            Console.WriteLine(nametrainer + "'s " + charmanderinstance.Name + " returns to its pokeball");
        }
        else if (randomnumber == 2)
        {
            Console.WriteLine(nametrainer + "'s " + squirtleinstance.Name + " returns to its pokeball");
        }
        else if (randomnumber == 3)
        {
            Console.WriteLine(nametrainer + "'s " + bulbasaurinstance.Name + " returns to its pokeball");
        }   
    }
}

