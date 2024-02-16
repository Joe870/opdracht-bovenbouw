using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
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