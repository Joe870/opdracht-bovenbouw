using System;
using System.Collections.Generic;

class Trainer
{
    Pokeball pokeballinstance = new Pokeball();
    public string nametrainer1;
    public string nametrainer2;
    public List<Pokeball>? pokebelt;
    public int amount_pokeballs = 0;
    public bool has_pokemon = true;
    Charmander charmanderinstance = new Charmander("Strength","Weakness","Name"); 
    public Trainer(string nametrainer1, string nametrainer2)
    {
        this.nametrainer1 = nametrainer1;
        this.nametrainer2 = nametrainer2;
    }

    // takePokeball(Pokeball pokeball)
        // Als meer dan zes pokeballs in de belt zit, dan gooi een error.
        // belt.Add(Pokeball)

    public string getName1()
    {
        Console.WriteLine("what name do you want to give the first trainer?");
        string nametrainer1 = Console.ReadLine();
        return nametrainer1;
    }
    public void setName1(string newname)
    {
        this.nametrainer1 = newname;
    }
    public string getName2()
    {
        Console.WriteLine("what name do you want to give the second trainer");
        string nametrainer2 = Console.ReadLine();
        return nametrainer2;
    }
    public void setName2(string newname)
    {
        this.nametrainer2 = newname;
    }
    public void trowPokeball()
    {
        if (amount_pokeballs <= 6)
        {
            has_pokemon = true;
            charmanderinstance.doGrowl();
            amount_pokeballs -= 1;
        }
        else
        {
            has_pokemon = false;
            Console.WriteLine("you're pokeball is empty");
        }
    }
    public void takePokeball() {
        amount_pokeballs += 1;
        if (amount_pokeballs >= 6) 
        {
            amount_pokeballs = 6;
            Console.WriteLine("You have 6 pokemon");
        }
        else
        {
            amount_pokeballs += 1;
            Console.WriteLine("you have " + amount_pokeballs + " pokemon");
        }
    }
}
