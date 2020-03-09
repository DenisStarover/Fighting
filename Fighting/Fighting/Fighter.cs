using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public interface IFighter
    {
        /// <summary>
        /// Получить здоровье
        /// </summary>
        /// <returns></returns>
        int GetHealth();
        /// <summary>
        /// Отнять здоровье
        /// </summary>
        /// <param name="hit"></param>
        /// <returns></returns>
        int LowHealth(int hit);
        /// <summary>
        /// Нанести удар
        /// </summary>
        /// <returns></returns>
        int GetDammageValue();
    }
    public class Fighter : BaseFighter
    {
        public string Name;
        public int MaxHit;
        public int MinHit;

        public override int GetDammageValue()
        {
            Random random = new Random();
            int hit = random.Next(MinHit, MaxHit);
            return hit;
        }
    }
}
