﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public interface IFighter
    {
        /// <summary>
        /// Получить имя.
        /// </summary>
        /// <returns></returns>
        string GetName();
        /// <summary>
        /// Получить здоровье.
        /// </summary>
        /// <returns></returns>
        int GetHealth();
        /// <summary>
        /// Отнять здоровье.
        /// </summary>
        /// <param name="hit"></param>
        /// <returns></returns>
        int LowHealth(int hit);

        /// <summary>
        /// Нанести удар.
        /// </summary>
        /// <returns></returns>
        int GetDammageValue();
    }
    public class TomFighter : BaseFighter
    {
        public override int GetMax() => 20;
        public override int GetMin() => 10;
        public override string GetName() => "Tom";
    }

    public class FredFighter : BaseFighter
    {
        public override int GetMax() => 21;
        public override int GetMin() => 8;
        public override string GetName() => "Fred";
    }
}
