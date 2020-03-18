namespace Fighting
{
    public interface IName
    {
        /// <summary 
        ///  Получить имя.
        /// </summary>
        /// <returns></returns>
        string GetName();
    }
    public interface IFighter : IName
    {
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
        /// Получить значение урона.
        /// </summary>
        /// <returns></returns>
        int GetDammageValue();
    }
    public class TomFighter : BaseFighter, IName
    {
        public override int GetMax() => 20;
        public override int GetMin() => 10;
        public override string GetName() => "Tom";
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get; set; }
        public TomFighter(IWeapon weapon, IArmor armor)
        {
            Weapon = weapon;
            Armor = armor;
        }
        public override int DammageValue() => Weapon.DammageValue();
        public override int ArmorValue() => Armor.ArmorValue();
        public override int StrenghtLoss() => Armor.StrenghtLoss();
    }

    public class FredFighter : BaseFighter, IName
    {
        public override int GetMax() => 21;
        public override int GetMin() => 8;
        public override string GetName() => "Fred";
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get; set; }
        public FredFighter(IWeapon weapon, IArmor armor)
        {
            Weapon = weapon;
            Armor = armor;
        }
        public override int DammageValue() => Weapon.DammageValue();
        public override int ArmorValue() => Armor.ArmorValue();
        public override int StrenghtLoss() => Armor.StrenghtLoss();
    }

    public class JimFighter : BaseFighter, IName
    {
        public override int GetMax() => 19;
        public override int GetMin() => 12;
        public override string GetName() => "Jim";
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get; set; }
        public JimFighter(IWeapon weapon, IArmor armor)
        {
            Weapon = weapon;
            Armor = armor;
        }
        public override int DammageValue() => Weapon.DammageValue();
        public override int ArmorValue() => Armor.ArmorValue();
        public override int StrenghtLoss() => Armor.StrenghtLoss();
    }

    public class JackFighter : BaseFighter, IName
    {
        public override int GetMax() => 18;
        public override int GetMin() => 15;
        public override string GetName() => "Fred";
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get; set; }
        public JackFighter(IWeapon weapon, IArmor armor)
        {
            Weapon = weapon;
            Armor = armor;
        }
        public override int DammageValue() => Weapon.DammageValue();
        public override int ArmorValue() => Armor.ArmorValue();
        public override int StrenghtLoss() => Armor.StrenghtLoss();
    }

}
