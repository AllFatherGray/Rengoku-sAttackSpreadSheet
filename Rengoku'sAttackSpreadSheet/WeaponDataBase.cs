using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rengoku_sAttackSpreadSheet.MHDBEnum;
using WeaponData = System.String;
namespace Rengoku_sAttackSpreadSheet
{

    public static class WeaponDataBase
    {
        private static readonly Dictionary<WeaponClass, WeaponData> WeaponInfo;
        static WeaponDataBase()
        {
            WeaponInfo = new Dictionary<WeaponClass, WeaponData>(14)
            {
                Enum.GetValues(typeof(WeaponClass)).Cast<WeaponClass>().Select((w) => new KeyValuePair<WeaponClass, WeaponData>(w, Properties.Resources.ResourceManager.GetObject(w.ToString() + "MV").ToString()))
            };
        }
        #region Class Methods
        public static decimal GetWeaponModifier(WeaponClass w)
        {
            switch(w)
            {
                case WeaponClass.GreatSword: return 4.8m;
                case WeaponClass.LongSword: return 3.3m;

                case WeaponClass.SwordShield: return 1.4m;
                case WeaponClass.DualSwords: return 1.4m;

                case WeaponClass.Hammer: return 5.2m;
                case WeaponClass.HuntingHorn: return 4.2m;

                case WeaponClass.Lance: return 2.3m;
                case WeaponClass.Gunlance: return 2.3m;

                case WeaponClass.InsectGlaive: return 3.1m;
                case WeaponClass.SwitchAxe: return 3.5m;

                case WeaponClass.ChargeBlade: return 3.6m;
                case WeaponClass.Bow: return 1.2m;

                case WeaponClass.LightBowGun: return 1.3m;
                case WeaponClass.HeavyBowGun: return 1.5m;

                default: return 0;
            }
        }
        public static string GetWeaponMotionValues(WeaponClass w) => WeaponInfo[w] ?? string.Empty;
        public static decimal GetSharpnessModifier(SharpnessColor s)
        {
            switch (s)
            {
                case SharpnessColor.Red: return .5m;
                case SharpnessColor.Orange: return .75m;
                case SharpnessColor.Yellow: return 1.0m;
                case SharpnessColor.Green: return 1.05m;
                case SharpnessColor.Blue: return 1.20m;
                case SharpnessColor.White: return 1.32m;
                default: return 0;
            }
        }
        public static int GetAttackModifier(Resentment r)
        {
            switch (r)
            {
                case Resentment.Level_1: return 5;
                case Resentment.Level_2: return 10;
                case Resentment.Level_3: return 15;
                case Resentment.Level_4: return 20;
                case Resentment.Level_5: return 25;

                default: return 0;
            }
        }
        public static int GetAttackModifier(AttackBoost a)
        {
            switch (a)
            {
                case AttackBoost.Level_1: return 3;
                case AttackBoost.Level_2: return 6;
                case AttackBoost.Level_3: return 9;
                case AttackBoost.Level_4: return 12;
                case AttackBoost.Level_5: return 15;
                case AttackBoost.Level_6: return 18;
                case AttackBoost.Level_7: return 21;

                default: return 0;
            }
        }
        public static int GetAffinityModifier(AttackBoost a)
        {
            switch (a)
            {
                case AttackBoost.Level_4:
                case AttackBoost.Level_5:
                case AttackBoost.Level_6:
                case AttackBoost.Level_7:
                    return 5;
                default: return 0;
            }
        }
        public static decimal GetCritBoostAffinity(CriticalBoost cb)
        {
            switch (cb)
            {
                case CriticalBoost.Level_1:return 1.30m;
                case CriticalBoost.Level_2: return 1.35m;
                case CriticalBoost.Level_3: return 1.40m;
                default: return MHConstants.CriticalHit;
            }
        }
        public static int GetAffinityModifier(CriticalEye c)
        {
            switch (c)
            {
                case CriticalEye.Level_1: return 3;
                case CriticalEye.Level_2: return 6;
                case CriticalEye.Level_3: return 10;
                case CriticalEye.Level_4: return 15;
                case CriticalEye.Level_5: return 20;
                case CriticalEye.Level_6: return 25;
                case CriticalEye.Level_7: return 30;
                default: return 0;
            }
        }
        public static int GetAffinityModifier(WeaknessExploit w)
        {
            switch (w)
            {
                case WeaknessExploit.Level_1: return 15;
                case WeaknessExploit.Level_2: return 30;
                case WeaknessExploit.Level_3: return 50;
                default: return 0;
            }
        }
        public static int GetHeroicsModifier(Heroics h)
        {
            switch (h)
            {
                case Heroics.Level_1: return 5;
                case Heroics.Level_2: return 10;
                case Heroics.Level_3: return 15;
                case Heroics.Level_4: return 20;
                case Heroics.Level_5: return 30;
                default: return 0;
            }
        }
        public static int GetAttackModifier(PowerCharms pc)
        {
            switch (pc)
            {
                case PowerCharms.PowerCharm: return 7;
                case PowerCharms.PowerTalon: return 8;
                case PowerCharms.Both: return 15;
                default: return 0;
            }
        }
        #endregion
    }
    public static class MHConstants
    {
        public const decimal FeebleHit = 0.75m;
        public const decimal CriticalHit = 1.25m;
    }
    namespace MHDBEnum
    {
        public enum WeaponClass
        {
            GreatSword,
            LongSword,
            SwordShield,
            DualSwords,
            Hammer,
            HuntingHorn,
            Lance,
            Gunlance,
            InsectGlaive,
            SwitchAxe,
            ChargeBlade,
            Bow,
            LightBowGun,
            HeavyBowGun
        }
        public enum SharpnessColor
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            White
        }

        public enum AttackBoost
        {
            None,
            Level_1,
            Level_2,
            Level_3,
            Level_4,
            Level_5,
            Level_6,
            Level_7
        }
        public enum CriticalEye
        {
            None,
            Level_1,
            Level_2,
            Level_3,
            Level_4,
            Level_5,
            Level_6,
            Level_7
        }
        public enum CriticalBoost
        {
            None,
            Level_1,
            Level_2,
            Level_3,
        }
        public enum Heroics
        {
            None,
            Level_1,
            Level_2,
            Level_3,
            Level_4,
            Level_5
        }
        public enum Resentment
        {
            None,
            Level_1,
            Level_2,
            Level_3,
            Level_4,
            Level_5
        }
        public enum WeaknessExploit
        {
            None,
            Level_1,
            Level_2,
            Level_3
        }
        [System.Flags]
        public enum PowerCharms
        {
            None,
            PowerCharm,
            PowerTalon,
            Both
        }
    }
}
