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
            Fighter tom = new Fighter
            {
                Name = "Tom",
                MinHit = 2,
                MaxHit = 15
            };

            Fighter fred = new Fighter
            {
                Name = "Fred",
                MinHit = 5,
                MaxHit = 13
            };


            Console.WriteLine($"{tom.Name} start health: {tom.GetHealth()} \n{fred.Name} start health: {fred.GetHealth()} ");
            Console.WriteLine("Start!");
            for (int i = 100; i >= 0;)
            {
                Console.ReadKey();
                int dammageTom = fred.GetDammageValue();
                Console.WriteLine($"{tom.Name}'s dammage: {dammageTom}");
                int b = tom.LowHealth(dammageTom);
                if (b <= 0)
                {
                    Console.WriteLine($"{fred.Name} win!!!");
                    break;
                }
                Console.WriteLine($"{tom.Name}'s health: {b}");

                Console.WriteLine();

                Console.ReadKey();
                int dammageFred = tom.GetDammageValue();
                Console.WriteLine($"{fred.Name}'s dammage: {dammageFred}");
                int a = fred.LowHealth(dammageFred);
                if (a <= 0)
                {
                    Console.WriteLine($"{tom.Name} win!!!");
                    break;
                }
                Console.WriteLine($"{fred.Name}'s health: {a}");
                Console.WriteLine();
            }

            Console.ReadLine();

        }


    }
}
