using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public interface IArmor : IName
    {
        /// <summary>
        /// Получить значение защиты, снижающей получаемый урон.
        /// </summary>
        /// <returns></returns>
        int ArmorValue();
        /// <summary>
        /// Значение потери силы от надетой брони.
        /// </summary>
        /// <returns></returns>
        int StrenghtLoss();

    }
    public class NoneArmor : IArmor
    {
        public int ArmorValue() => 0;
        public int StrenghtLoss() => 0;
        public string GetName() => "None armor";
    }
    public class LightArmor : IArmor
    {
        public int ArmorValue()
        {
            Random random = new Random();
            int armor = random.Next(0,3);
            return armor;
        }
        public int StrenghtLoss() => 2;
        public string GetName() => "Light armor";
    }

    public class HeavyArmor : IArmor
    {
        public int ArmorValue()
        {
            Random random = new Random();
            int armor = random.Next(2,5);
            return armor;
        }
        public int StrenghtLoss() => 5;
        public string GetName() => "Heavy armor";
    }

    public class Armour : IArmor
    {
        public int ArmorValue()
        {
            Random random = new Random();
            int armor = random.Next(5, 15);
            return armor;
        }
        public int StrenghtLoss() => 10;
        public string GetName() => "Armour";
    
    }
}
