using System;
using System.Security.Cryptography.X509Certificates;

class Battle
{
    public Pokemon pokemon1;
    public Pokemon pokemon2;
    public int wins_trainer1;
    public int wins_trainer2;
    public int draws;
    public bool outcomewins;
    public bool outcomedraw;
    public static int round = 0;
    public static int battle = 0;
    public int pokeball_trainer1 = 0;
    public int pokeball_trainer2 = 0;
    public Battle()
    {
        List<Pokeball> pokebelt = new List<Pokeball>();
        Pokeball pokeballinstance = new Pokeball();
        Trainer trainer1 = new Trainer("joelle", pokebelt);
        Trainer trainer2 = new Trainer("tommy", pokebelt);
        trainer1.setName(trainer1.getName());
        trainer2.setName(trainer2.getName());
        
        for (int l = 0; l < 6; l++)
        {
            Pokemon charmander = new Charmander("charmander", "fire", "water");
            Pokemon squirtle = new Squirtle("squirtle", "water", "grass");
            Pokemon bulbasaur = new Bulbasaur("bulbasaur", "grass", "fire");
            Pokeball pokeball = new Pokeball();
            pokebelt.Add(pokeball);
            Console.WriteLine("dit is loop nummer " + l + "");
        }
        bool doorgaan = true;
        while (doorgaan == true)
        {
            for (int I = 0; I < 6; I++)
            {
                if(pokeball_trainer1<6 || pokeball_trainer2 < 6)
                {

                }
                Console.WriteLine("Do you want to keep playing this battle");
                String keep_playing_round = Console.ReadLine();
                if (keep_playing_round == "ja")
                {
                    doorgaan = true;
                }
                else
                {
                    doorgaan = false;
                    break;
                }
                if (doorgaan != false)
                {
                    if (round == 0)
                    {
                        pokemon1 = trainer1.throwPokeball();
                        pokemon2 = trainer2.throwPokeball();
                        pokeball_trainer1 += 1;
                        pokeball_trainer2 += 1;
                    }
                    outcomewins = pokemon1.isWeakAgainst(pokemon1, pokemon2);
                    if (outcomewins == true)
                    {
                        wins_trainer1 += 1;
                        trainer2.returnPokemon();
                        pokemon2 = trainer2.throwPokeball();
                        pokeball_trainer2 += 1;
                        round += 1;
                    }
                    outcomedraw = pokemon1.isDraw(pokemon1, pokemon2);
                    if (outcomedraw == true)
                    {
                        draws += 1;
                        trainer1.returnPokemon();
                        trainer2.returnPokemon();
                        pokemon1 = trainer1.throwPokeball();
                        pokemon2 = trainer2.throwPokeball();
                        pokeball_trainer1 += 1;
                        pokeball_trainer2 += 1;
                        round += 1;
                    }
                    if (outcomedraw == false && outcomewins == false)
                    {
                        wins_trainer2 += 1;
                        trainer1.returnPokemon();
                        pokemon1 = trainer1.throwPokeball();
                        pokeball_trainer1 += 1;
                        round += 1;
                    }
                    if (pokeball_trainer1 > 6 || pokeball_trainer2 > 6)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("you don't have any pokemon left. battle over");
            battle += 1;
            Console.WriteLine("Do you want to start another battle");
            String keep_playing_battle = Console.ReadLine();
            if (keep_playing_battle == "ja")
            {
                doorgaan = true;
            }
            else doorgaan = false;
        }
    }
}
