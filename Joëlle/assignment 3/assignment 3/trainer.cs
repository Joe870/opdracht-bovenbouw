using System;
using System.Xml;

class Trainer
{
    Pokeball pokeballinstance = new Pokeball();
    public string nametrainer;
    public List<Pokeball>? pokebelt;
    public int amount_pokeballs_trainer = 1;
    public bool has_pokemon = true;
    public Charmander charmanderinstance = new Charmander("charmander", "fire", "water");
    public Squirtle squirtleinstance = new Squirtle("squirtle", "water", "grass");
    public Bulbasaur bulbasaurinstance = new Bulbasaur("bulbasaur", "grass", "fire");
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
    public void throwPokeball()
    {
        if (amount_pokeballs_trainer <= 2)
        {

            has_pokemon = true;
            Console.WriteLine(nametrainer + "throws his " + amount_pokeballs_trainer + " pokeball");
            String growl = charmanderinstance.doGrowl();
            Console.WriteLine(growl);
            amount_pokeballs_trainer += 1;
        }
        else if (amount_pokeballs_trainer <= 4)
        {
            has_pokemon = true;
            Console.WriteLine(nametrainer + "throws his " + amount_pokeballs_trainer + " pokeball");
            String growl = squirtleinstance.doGrowl();
            Console.WriteLine(growl);
            amount_pokeballs_trainer += 1;
        }
        else if (amount_pokeballs_trainer <= 6)
        {
            has_pokemon = true; 
            Console.WriteLine(nametrainer + "throws his " + amount_pokeballs_trainer + " pokeball");
            String growl = bulbasaurinstance.doGrowl();
            Console.WriteLine(growl);
            amount_pokeballs_trainer += 1;
        }
    }
    public void takePokeball()
    {
        charmanderinstance.doGrowl();
    }
    public void returnPokemon()
    {
        if (amount_pokeballs_trainer <= 3)
            Console.WriteLine(nametrainer + "'s " + charmanderinstance.Name + " returns to its pokeball");
        else if (amount_pokeballs_trainer <= 5)
            Console.WriteLine(nametrainer + "'s " + squirtleinstance.Name + " returns to its pokeball");
        else if (amount_pokeballs_trainer <= 7)
            Console.WriteLine(nametrainer + "'s " + bulbasaurinstance.Name + " returns to its pokeball");
    }
}
