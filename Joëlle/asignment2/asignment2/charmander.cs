using System;

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
    public String doGrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
}

