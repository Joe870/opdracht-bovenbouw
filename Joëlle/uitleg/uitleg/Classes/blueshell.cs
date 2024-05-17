namespace OOPDemo_Re.classes
{
    class BlueShell : Items
    {
        public int speed;
        public BlueShell(string target, string name, int amount, int speed) : base(target, name, amount)
        {
            this.speed = speed; 
        }

        public void explode()
        {
            Console.WriteLine(this.name + "Explodes!!!");
        }
    }
}