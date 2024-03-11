using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


abstract class Pokemon
{
    public string nickName;
    public string strength;
    public string weakness;

    public Pokemon(string nickName, string strength, string weakness)
    {
        this.nickName = nickName;
        this.strength = strength;
        this.weakness = weakness;
    }

    public string getName()
    {
        return this.nickName;
    }

    public abstract void battleCry();
}

class Charmander : Pokemon
{
    public Charmander(string nickName, string strength, string weakness) : base(nickName, strength, weakness)
    {
        this.nickName = "Charmander";
        this.strength = "fire";
        this.weakness = "water";
    }

    public override void battleCry()
    {
        int amountBattleCry = 10;
        for (int i = 0; i < amountBattleCry; i++)
        {
            Console.WriteLine(this.nickName + "!!!");
        }
    }
}

class Squirtle : Pokemon
{
    public Squirtle(string nickName, string strength, string weakness) : base(nickName, strength, weakness)
    {
        this.nickName = "Squirtle";
        this.strength = "water";
        this.weakness = "leaf";
    }

    public override void battleCry()
    {
        int amountBattleCry = 10;
        for (int i = 0; i < amountBattleCry; i++)
        {
            Console.WriteLine(this.nickName + "!!!");
        }
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickName, string strength, string weakness) : base(nickName, strength, weakness)
    {
        this.nickName = "Bulbasaur";
        this.strength = "grass";
        this.weakness = "fire";
    }

    public override void battleCry()
    {
        int amountBattleCry = 10;
        for (int i = 0; i < amountBattleCry; i++)
        {
            Console.WriteLine(this.nickName + "!!!");
        }
    }
}