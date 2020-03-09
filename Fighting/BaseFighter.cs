using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public abstract class BaseFighter : IFighter
    {
        protected int Health = 100;

        public abstract string GetName();
        public int GetHealth()
        {
            return Health;
        }
        public int LowHealth(int hit)
        {
            Health -= hit;
            return Health;
        }
        public int GetDammageValue()
        {
            Random random = new Random();
            int hit = random.Next(GetMin(), GetMax());
            return hit;
        }
        public abstract int GetMin();
        public abstract int GetMax();
    }

}
