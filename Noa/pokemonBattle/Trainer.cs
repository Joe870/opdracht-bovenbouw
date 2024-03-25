using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//Trainer class
class Trainer
{
    public readonly string name;
    public int amountBelt;
    public List<Pokeball> belt;
    public int index {  get; set; }

    public Trainer(string name, List<Pokeball> belt)
    {
        this.name = name;
        this.amountBelt = 6;
        this.belt = beltContent();
    }

    public List<Pokeball> beltContent()
    {
        List<Pokeball> beltContent = new List<Pokeball>();
        Charmander charmander = new Charmander("Charmander", "fire", "water");
        Squirtle squirtle = new Squirtle("Squirtle", "water", "leaf");
        Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "grass", "fire");
        Pokemon[] poke = { charmander, squirtle, bulbasaur };
        List<Pokemon> pokemon = new List<Pokemon>(poke);
        for (int i = 0; i < amountBelt/3; i++)
        {
            for (int x = 0; x < amountBelt/2; x++)
            {
                Pokeball pokeball = new Pokeball(pokemon[x]);
                beltContent.Add(pokeball);
            }
        }
        return beltContent;
    }

    public Pokemon throwPokeball()
    {
        var random = new Random();
        Charmander charmander = new Charmander("Charmander", "fire", "water");
        Pokeball pokeball = new Pokeball(charmander);
        index = random.Next(this.belt.Count);
        Pokeball thrownPokeball = this.belt[index];
        Pokemon pokemonFromBall = pokeball.openPokeball(thrownPokeball);
        return pokemonFromBall;
    }

    public void returnPokemon(Pokemon pokemonOutBall)
    {
        Pokeball pokeball = new Pokeball(pokemonOutBall);
        this.belt.RemoveAt(index);
        pokeball.closePokeball();
    }
}