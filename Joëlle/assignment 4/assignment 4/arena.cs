using System;

public class Arena
{
    Battle battleinstance = new Battle();
    public Arena()
    {
        Console.WriteLine("this is round" + Battle.round);
        Console.WriteLine("this is battle" + Battle.battle);
    }
}
