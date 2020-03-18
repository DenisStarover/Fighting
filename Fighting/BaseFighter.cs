using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public abstract class BaseFighter : IFighter, IWeapon, IArmor
    {
        public abstract string GetName();

        protected int Health = 100;
        public int GetHealth()
        {
            return Health;
        }
        public int LowHealth(int hit)
        {
            int c = ArmorValue();
            Health -= (hit - c);
            return Health;
        }
        public int GetDammageValue()
        {
            Random random = new Random();
            int a = DammageValue();
            int b = StrenghtLoss();
            int hit = random.Next(GetMin(), GetMax());
            hit += (a - b);
            return hit;
        }
        public abstract int GetMin();
        public abstract int GetMax();

        public abstract int DammageValue();
        public abstract int ArmorValue();
        public abstract int StrenghtLoss();
    }

}
