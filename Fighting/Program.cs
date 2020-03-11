using System;


namespace Fighting
{
    class Program
    {
        private static void Swap(ref IFighter a, ref IFighter b)
        {
            IFighter c = a; 
            a = b; 
            b = c;
        }

    
        static void Main(string[] args)
        {

            IFighter tom = new TomFighter();
            IFighter fred = new FredFighter();

            Console.WriteLine($"{tom.GetName()} start health: {tom.GetHealth()} \n{fred.GetName()} start health: {fred.GetHealth()} ");
            Console.WriteLine("Start!");
            while (true)
            {
                Console.ReadKey();
                var c = Fight(tom, fred);
                Swap(ref tom, ref fred);
                Console.WriteLine();
                if (c)
                break;
            }
        }

        public static bool Fight(IFighter hitFighter, IFighter getFighter)
        {
            getFighter.LowHealth(hitFighter.GetDammageValue());
            Console.WriteLine($"{getFighter.GetName()}'s dammage: {hitFighter.GetDammageValue()}");
            if (getFighter.GetHealth() <= 0)
            {
                Console.WriteLine($"{hitFighter.GetName()} win!!!");
                Console.ReadLine();
            }
            else
                Console.WriteLine($"{getFighter.GetName()}'s health: {getFighter.GetHealth()}");
            return (getFighter.GetHealth() <= 0);
        }
    }
}
