using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// stap 1 the player starts the game

// stap 6 repeat stap 4 and 5 until the player quits the game
class Program {
    public String Name;
    public String Strength;
    public String Weakness;

    // make a contructor out of it    
    public String charmander(String Strength, String Weakness, String Name){
        this.Name = Name;
        this.Strength = Strength;
        this.Weakness = Weakness;
    }
// stap 3 the charmander does its battle cry for ten times 
// stap 5 the charmander does its battle cry for ten times 

}

class charmander
{
    public String Name;
    public String Strength;
    public String Weakness;

    public string getName()
    {
            // stap 2 the player gives a name to a charmander
            // stap 4 the player can give a new name to the same charmander
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
    public String dogrowl()
    {
        return "raawr, ik ben " + this.Name;
    }
    public String loop()
    {
        for (int i = 0; i < 11; i++)
        {
            public String doorgaan = Console.WriteLine("Do you want to play?");
            if (doorgaan != "ja")
            {
                Console.WriteLine("Game over!");
                break;
            }
    }
}
