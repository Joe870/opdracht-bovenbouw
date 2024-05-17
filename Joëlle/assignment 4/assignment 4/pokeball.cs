using System;

class Pokeball
{
    int pokeball_amount = 6;
    // Pokemon pokemon;
    Pokemon charmanderinstance = new Charmander("charmander", "fire", "water");
    Pokemon squirtleinstance = new Squirtle("squirtle", "water", "grass");
    Pokemon bulbasaurinstance = new Bulbasaur("bulbasaur", "grass", "fire");
    public bool haspokemon()
    {
        if (pokeball_amount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string open()
    {
        return charmanderinstance.doGrowl();
    }

    public string close()
    {
        return "you're pokemon has been defeated and has returned to its pokeball";
    }
}

