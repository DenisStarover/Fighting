using System;

namespace Fighting
{
    public interface IWeapon : IName
    {
        /// <summary>
        /// Значение увеличения урона.
        /// </summary>
        /// <returns></returns>
        int DammageValue();
    }

    public class Hand : IWeapon, IName
    {
        public int DammageValue() => 0;
        public string GetName() => "Hand"; 
    }
    public class KnuckleDuster : IWeapon, IName
    {
        public int DammageValue() => 2;
        public string GetName() => "Knuckle-duster";
    }
    public class Bat : IWeapon, IName
    {
        public int DammageValue()
        {
            Random c = new Random();
            int dammage = c.Next(2, 5);
            return dammage;
        }
        public string GetName() => "Bat";
    }
    public class Knife : IWeapon, IName
    {
        public int DammageValue() => 4;
        public string GetName() => "Knife";
    }

    public class Sword : IWeapon, IName
    {
        public string GetName() => "Sword";
        public int DammageValue() => 5;
    }
}
