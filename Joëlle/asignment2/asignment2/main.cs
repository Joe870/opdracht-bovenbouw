using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

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
class Program
{
    public static void Main(String[] args)
    {
        Charmander charmander = new Charmander("fire", "water", "charmander");
        Trainer trainer1 = new Trainer("trainer1", "trainer2");
        Trainer trainer2 = new Trainer("trainer1", "trainer2");
        // Trainer trainer2 = new Trainer();

        for (int I = 0; I < 6; I++)
        {

             List<Pokeball> pokebelt = new List<Pokeball>();
            trainer1.takePokeball();
            trainer2.takePokeball(); 
          
            // maak een pokeball object aan en geef die mee:
            //trainer.takePokeball(pokeball);

            // geef je de pokeballs aan beide trainers (want ze hebben beide een belt).
        }

        Pokeball pokeball = new Pokeball();
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
                String trainername1 = trainer1.getName1();
                trainer1.nametrainer1 = trainername1;
                String trainername2 = trainer2.getName2();
                trainer2.nametrainer2 = trainername2; 
                for (int i = 0; i < 10; i++)
                {
                    String growl = charmander.doGrowl();
                    Console.WriteLine(growl);
                }
            }
        }
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
    }
}



