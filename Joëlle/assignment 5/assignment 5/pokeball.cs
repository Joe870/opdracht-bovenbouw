using System;

public class Pokeball
{
    private int pokeball_amount = 6;
    private Pokemon charmanderinstance = new Charmander("charmander", PokemonTypes.fire, PokemonTypes.water);
    private Pokemon squirtleinstance = new Squirtle("squirtle", PokemonTypes.water, PokemonTypes.grass);
    private Pokemon bulbasaurinstance = new Bulbasaur("bulbasaur", PokemonTypes.grass, PokemonTypes.fire);
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