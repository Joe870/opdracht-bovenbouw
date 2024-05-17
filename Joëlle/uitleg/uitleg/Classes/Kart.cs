namespace OOPDemo_Re
{
    class Kart
    {
        public float speed;
        public string tyretypes;
        public string color;

        public Kart(float speed, string tyretypes, string color)
        {
            this.speed = speed;
            this.tyretypes = tyretypes;
            this.color = color;
        }
        public void glide()
        {
            // functionaliteit voor het glide
            Console.WriteLine("Ik gebruik vleugels om een stuk te gliden.");
        }
        public void brake()
        {
            while (this.speed > 0)
            {
                this.speed = this.speed - 5;
            }
        }
    }
}