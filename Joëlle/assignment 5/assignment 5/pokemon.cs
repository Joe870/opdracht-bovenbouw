using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Pokemon
{
    protected string Name;
    protected PokemonTypes Strength;
    protected PokemonTypes Weakness;

    public Pokemon(string Name, PokemonTypes Strength, PokemonTypes Weakness)
    {
        this.Name = Name;
        this.Strength = Strength;
        this.Weakness = Weakness;
    }

    public string getName()
    {
        return this.Name;
    }
    public void setName(string newname)
    {
        this.Name = newname;
    }

    public PokemonTypes getStrength()
    {
        return this.Strength;
    }

    public void setStrength(PokemonTypes Newstrength)
    {
        this.Strength = Newstrength;
    }

    public PokemonTypes getWeakness()
    {
        return this.Weakness;
    }

    public void setWeakness(PokemonTypes Newweakness)
    {
        this.Weakness = Newweakness;
    }
    public abstract string doGrowl();

    public bool isWeakAgainst(Pokemon trainer1pokemon, Pokemon trainer2pokemon)
    {
        return trainer1pokemon.Weakness.Equals(trainer2pokemon.Strength);
    }
    public bool isDraw(Pokemon trainer1pokemon, Pokemon trainer2pokemon)
    {
        return trainer1pokemon.Strength.Equals(trainer2pokemon.Strength);
    }
}

class Charmander : Pokemon
{
    public Charmander(string Name, PokemonTypes Strength, PokemonTypes Weakness) : base(Name, Strength, Weakness)
    {

    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}

class Squirtle : Pokemon
{
    public Squirtle(string Name, PokemonTypes Strength, PokemonTypes Weakness) : base(Name, Strength, Weakness)
    {

    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string Name, PokemonTypes Strength, PokemonTypes Weakness) : base(Name, Strength, Weakness)
    {

    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}
