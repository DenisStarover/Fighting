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
            IWeapon w1 = new KnuckleDuster();
            IWeapon w2 = new Sword();
            IArmor a1 = new LightArmor();
            IArmor a2 = new HeavyArmor();
            IFighter f1 = new JimFighter(w1, a1);
            IFighter f2 = new JackFighter(w2, a2);

            Console.WriteLine($"{f1.GetName()} start health: {f1.GetHealth()}, weapon: {w1.GetName()}, armor: {a1.GetName()} \n" +
                $"\n{f2.GetName()} start health: {f2.GetHealth()}, weapon: {w2.GetName()}, armor: {a2.GetName()}");
            Console.WriteLine("\nSTART! \n");
            while (true)
            {
                Console.ReadKey();
                var c = Fight(f1, f2);
                Swap(ref f1, ref f2);
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
