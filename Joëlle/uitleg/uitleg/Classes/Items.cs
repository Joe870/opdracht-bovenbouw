namespace OOPDemo_Re.classes
{
    class Items
    {
        public string target;
        public string name;
        public int amount;

        public Items(string target, string name, int amount)
        {
            this.target = target;
            this.name = name;
            this.amount = amount;
        }

        public void pickUp()
        {
            Console.WriteLine("Activated" + this.name);
        }
        public void active()
        {
            Console.WriteLine("Activated" + this.name);
        }
    }
}
