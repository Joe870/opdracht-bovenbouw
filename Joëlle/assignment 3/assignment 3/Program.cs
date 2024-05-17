using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Pogram
{
    public static void Main(String[] args)
    {
        List<Pokeball> pokebelt = new List<Pokeball>();
        Trainer trainer1 = new Trainer("joelle", pokebelt);
        Trainer trainer2 = new Trainer("tommy", pokebelt);
        trainer1.setName(trainer1.getName());
        trainer2.setName(trainer2.getName());
        for (int l = 0; l < 6; l++)
        {
            Charmander charmander = new Charmander("charmander", "fire", "water");
            Squirtle squirtle = new Squirtle("squirtle", "water", "grass");
            Bulbasaur bulbasaur = new Bulbasaur("bulbasaur", "grass", "fire");
            Pokeball pokeball = new Pokeball();
            pokebelt.Add(pokeball);
            Console.WriteLine("dit is loop nummer " + l + "");
        }
        bool doorgaan = true;
        for (int I = 0; I < 6; I++)
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
                trainer1.throwPokeball();
                trainer2.throwPokeball();
                trainer1.returnPokemon();
                trainer2.returnPokemon();
            }
        }
        Console.WriteLine("you don't have any pokemon left. game over");
    }
}