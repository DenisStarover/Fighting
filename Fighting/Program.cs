using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {

            TomFighter tom = new TomFighter();
            FredFighter fred = new FredFighter();

            Console.WriteLine($"{tom.GetName()} start health: {tom.GetHealth()} \n{fred.GetName()} start health: {fred.GetHealth()} ");
            Console.WriteLine("Start!");
            while (true)
            {
                Console.ReadKey();
                int dammageTom = fred.GetDammageValue();
                Console.WriteLine($"{tom.GetName()}'s dammage: {dammageTom}");
                int b = tom.LowHealth(dammageTom);
                if (b <= 0)
                {
                    Console.WriteLine($"{fred.GetName()} win!!!");
                    break;
                }
                Console.WriteLine($"{tom.GetName()}'s health: {b}");

                Console.WriteLine();

                Console.ReadKey();
                int dammageFred = tom.GetDammageValue();
                Console.WriteLine($"{fred.GetName()}'s dammage: {dammageFred}");
                int a = fred.LowHealth(dammageFred);
                if (a <= 0)
                {
                    Console.WriteLine($"{tom.GetName()} win!!!");
                    break;
                }
                Console.WriteLine($"{fred.GetName()}'s health: {a}");
                Console.WriteLine();
            }

            Console.ReadLine();

        }


    }
}
