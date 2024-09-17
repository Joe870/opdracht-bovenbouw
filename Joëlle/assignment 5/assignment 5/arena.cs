using System;

public class Arena
{
    Battle battleinstance = new Battle();
    public int newRound;
    public int newBattle;
    public Arena()
    {
        Console.WriteLine("this is round" + battleinstance.getRound());
        Console.WriteLine("this is battle" + battleinstance.getBattle());
    }
}