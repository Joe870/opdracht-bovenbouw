using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// stap 1 the player starts the game.
// stap 2 the player gives a name to the first trainer
// stap 3 the player gives a name to the second trainer
// stap 4 the first trainer throws the first pokeball on its belt
// stap 5 the pokeball released the charmander and charmander
// stap 6 the second trainer throws the first pokeball on its belt
// stap 7 the pokeball released the charmander and charmander does its battle cry
// stap 8 the first trainer returns the charmander back to its pokeball
// stap 9 the second trainer returns the charmander back to its pokeball
// stap 10 repeat 4 to 9 untill all pokeballs have been used by both trainers
class Program {
    public static void Main(String[] args)
    {
        Charmander charmander = new Charmander("fire", "water", "charmander");
        bool doorgaan = true;
         while (doorgaan)
         {
            Console.WriteLine("Do you want to play");
            String keep_playing = Console.ReadLine();
            if (keep_playing == "ja")
            {
                doorgaan = true;
            }
            else
            {
                doorgaan = false;
            }
            if (doorgaan != false)
            {
                String charmandername = charmander.getName();
                charmander.Name = charmandername;
                for (int i = 0; i < 10; i++)
                {
                    String growl = charmander.dogrowl();
                    Console.WriteLine(growl);
                }
                }
            } 
        }

class Charmander
    {
        public String Name;
        public String Strength;
        public String Weakness;

        public Charmander(String Strength, String Weakness, String Name)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Weakness = Weakness;
        }
        public string getName()
        {
            Console.WriteLine("What name do you want to give you're charmander?");
            string Name = Console.ReadLine();
            return Name;
        }
        public void setName(String newName)
        {
            this.Name = newName;
        }
        public string getStrength()
        {
            return Strength;
        }
        public void setStrength(String newStrength)
        {
            this.Strength = newStrength;
        }
        public string getWeakness()
        {
            return Weakness;
        }
        public void setWeakness(String newWeakness)
        {
            this.Weakness = newWeakness;
        }
        public String dogrowl()
        {
            return "raawr, ik ben " + this.Name;
        }
    }
}


class pokeball
{
    bool has_pokemon = true; 
    public int amount_pokeballs = 6;
    public string open()
    {
        if(amount_pokeballs <= 6)
        {
            bool has_pokemon = true;
            string pokemon = "charmander";
            amount_pokeballs -= 1;
        }
        else { 
            has_pokemon = false;
            string pokemon = null;
        }
    }
    public void close()
    {
        amount_pokeballs += 1; 
        if (amount_pokeballs > 6)
        {
            amount_pokeballs = 6; 
        }
    }
}

class trainer
{
    public string nametrainer1;
    public string nametrainer2;
    public trainer(string nametrainer1, string nametrainer2)
    {
        this.nametrainer1 = nametrainer1;
        this.nametrainer2 = nametrainer2;
    }
    public string getname1()
    {
        console.writeline("what name do you want to give the first trainer?");
        string nametrainer1 = console.readline();
        console.writeline("what name do you want to give the second trianer");
        string nametrainer2 = console.readline();
        return nametrainer1, nametrainer2;
    }
    public void setname1(string newname)
    {
        this.nametrainer1 = newname;
    }
    public string getname2()
    {
        console.writeline("what name do you want to give the second trainer");
        string nametrainer2 = console.readline();
        return nametrainer2;
    }
    public void setname2(string newname)

    {
        this.nametrainer2 = newname;
    }
    public string throwpokeball()
    {
        charmander.dogrowl(); 
    }

    public string belt()
    {
        list<int> pokeballs = new list<int>();
    }
    public string returnpokemon()
    {

    }
}