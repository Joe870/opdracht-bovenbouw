using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Pogram
{
    //1. The player starts the game. done 
    //2. The player gives a name to the first trainer. done 
    //3. The player gives a name to the second trainer. done 
    //4. The first trainer throws the first pokeball on its belt. done 
    //5. The pokeball released the charmander and charmander does its battle cry. done 
    //6. The second trainer throws the first pokeball on its belt. done 
    //7. The pokeball released the charmander and charmander does its battle cry.
    //8. The first trainer returns the charmander back to its pokeball.
    //9. The second trainer returns the charmander back to its pokeball.
    //10. Repeat 4 to 9 until all pokeballs have been used by both trainers.
    //The player can quit or restart the game.
    public static void Main(String[] args)
    {
        List<Pokeball> pokebelt = new List<Pokeball>();
        Trainer trainer1 = new Trainer("joelle", pokebelt);
        Trainer trainer2 = new Trainer("tommy", pokebelt);
        trainer1.setName(trainer1.getName());
        trainer2.setName(trainer2.getName());
        for (int l = 0; l < 6; l++)
        {
            Charmander charmander = new Charmander("fire", "water", "charmander");
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
