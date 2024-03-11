using System;

class Program
{
    static void Main(string[] args)
    {
        Pokemon charmander = new Pokemon();
        Pokemon latios = new Pokemon();
        latios.setName("Flyboii");
        charmander.setName("Sparky");
        Console.WriteLine(latios.dogrowl());
    }
}

class Pokemon{
    public String name;

    public string getName()
    {
        return name;
    }
    public void setName(String newName)
    {
        this.name = newName;
    }
    public String dogrowl()
    {
        return "raawr, ik ben " + this.name;
    }
}
