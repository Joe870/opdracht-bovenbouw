using System;
using System.Security.Cryptography.X509Certificates;

abstract class Pokemon
{
    public String Name;
    public String Strength;
    public String Weakness; 

    public Pokemon(string Name, string Strength, string Weakness)
    {
        this.Name = Name;
        this.Strength = Strength;
        this.Weakness = Weakness;
    }
    public string getName()
    {
        Console.WriteLine("What name do you want to give you're pokemon?");
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
    public abstract string doGrowl(); 
}
class Charmander : Pokemon
{
    public Charmander(String Name, String Strength, String Weakness) : base(Name, Strength, Weakness)
    {
 
    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}

class Squirtle : Pokemon
{
    public Squirtle(String Name, String Strength, String Weakness) : base(Name, Strength, Weakness)
    {

    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(String Name, String Strength, String Weakness) : base(Name, Strength, Weakness)
    {

    }
    public override string doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}
