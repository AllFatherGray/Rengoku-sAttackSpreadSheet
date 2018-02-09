using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Rengoku_sAttackSpreadSheet.MHDBEnum;
namespace Rengoku_sAttackSpreadSheet
{
    public partial class CalculatorUI : Form
    {
        readonly EventHandler UpdateEvent = null;
        #region Properties
        private WeaponClass CurrentWeapon => (WeaponClass)WeaponSelectDropdownBox.SelectedIndex;
        private SharpnessColor CurrentSharpness => (SharpnessColor)SharpnessDropdownBox.SelectedIndex;

        // Modifiers
        private decimal CurrentRawSharpnessModifier => WeaponDataBase.GetRawSharpnessModifier(CurrentSharpness);
        private decimal CurrentElementalSharpnessModifier => WeaponDataBase.GetElementalSharpnessModifier(CurrentSharpness);
        private decimal CurrentWeaponModifier => WeaponDataBase.GetWeaponModifier(CurrentWeapon);
        private decimal CurrentHitZoneModifier => HitzoneModifier.Value / 100.0M;
        private decimal CurrentElementalHitZoneModifier => ElementalHitzoneModifier.Value / 100.0M;

        // Raw Attack Related Bonuses
        private decimal HeroicsBonus => WeaponDataBase.GetHeroicsModifier((Heroics)HeroicsDropBox.SelectedIndex);
        private decimal NonElementalBonus => (!ElementLessBonusBox.Checked || ElementalDamage.Value > 0) ? 1 : 1.1m;
        private int ResentmentBonus => WeaponDataBase.GetAttackModifier((Resentment)ResentmentDropBox.SelectedIndex);
        private int AttackBonus => WeaponDataBase.GetAttackModifier((AttackBoost)AttackBoostDropBox.SelectedIndex);
        private int PeekAttackBonus => WeaponDataBase.GetAttackModifier((PeakPerformance)PeekPerformDropBox.SelectedIndex);
        private int CharmBonus => WeaponDataBase.GetAttackModifier((PowerCharms)CharmsDropDown.SelectedIndex);
        private int FelyneBonus => WeaponDataBase.GetAttackModifier((FelyneFood)FelyneFoodDropBox.SelectedIndex);
        private int DemonBonus => WeaponDataBase.GetAttackModifier((DemonDrugs)DemonDrugDropBox.SelectedIndex);
        private int SeedPillBonus => WeaponDataBase.GetAttackModifier((SeedPill)SeedPillDropBox.SelectedIndex);


        // Affinity Related Bonuses
        private int CriticalEyeBonus => WeaponDataBase.GetAffinityModifier((CriticalEye)CriticalEyeDropBox.SelectedIndex);
        private int WeaknessExpoitBonus => WeaponDataBase.GetAffinityModifier((WeaknessExploit)WeaknessExploitDropBox.SelectedIndex);
        private int AttackCritBonus => WeaponDataBase.GetAffinityModifier((AttackBoost)AttackBoostDropBox.SelectedIndex);
        private decimal CritBoostBonus => WeaponDataBase.GetCritBoostAffinity((CriticalBoost)CriticalBoostDropBox.SelectedIndex);

        // Formula Results
        private string CurrentWeaponMotionValues
        {
            get
            {
                string nextMV = WeaponDataBase.GetWeaponMotionValues(CurrentWeapon);
                decimal tempFinalRaw = UseAffinityToggle.Checked ? WeaponDataBase.ApplyAffinity(TotalRaw, TotalAffinity, CritBoostBonus) : TotalRaw;
                switch(CurrentWeapon)
                {
                    case WeaponClass.HeavyBowGun:
                    case WeaponClass.LightBowGun:
                        {

                            break;
                        }
                    default:
                        {
                            var words = nextMV.Split(' ', '\n');
                            string CurrentWord = null;
                            for(int i = 0; i < words.Count() ;++i)
                            {
                                CurrentWord = words[i];
                                if (CurrentWord.Contains("<") && CurrentWord.Contains(">"))
                                {
                                    try
                                    {
                                        decimal MotionValue = Decimal.Parse(CurrentWord.Replace("<", string.Empty).Replace(">", string.Empty)) / 100m;

                                        words[i] = (Math.Round( tempFinalRaw * CurrentRawSharpnessModifier  * CurrentHitZoneModifier * MotionValue)).ToString() + (CurrentWord.Last() == '>' ? ' ' : CurrentWord.Last());
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            nextMV =  words.Aggregate((a, b) => a + ' ' + b);
                            break;
                        }
                }
                return nextMV;
            }
        }
        /// <summary>
        /// Raw Before any Affinity, Sharpness or Hitzone Modifiers
        /// </summary>
        private decimal TotalRaw
        {
            get
            {
                // Using Current User Values or A default value to look at Motion Values?
                decimal CurrentValue = !ShowModToggle.Checked ? TrueRaw.Value : 100;

                return (CurrentValue * NonElementalBonus * HeroicsBonus) + AttackBonus + PeekAttackBonus + ResentmentBonus + CharmBonus + FelyneBonus + DemonBonus + SeedPillBonus;
            }
        }
        private decimal FinalRaw
        {
            get
            {
                return (int)WeaponDataBase.ApplyAffinity(TotalRaw * CurrentRawSharpnessModifier, TotalAffinity, CritBoostBonus);
            }
        }
        private decimal FinalElementalDamage
        {
            get
            {
                return (int) (ElementalDamage.Value / 10) * CurrentElementalSharpnessModifier * CurrentElementalHitZoneModifier;
            }
        }
        private int TotalAffinity
        {
            get
            {
                int affinity = AttackCritBonus + CriticalEyeBonus + WeaknessExpoitBonus + (int)NaturalAffinity.Value;
                if (affinity > 100)
                    return 100;
                else if (affinity < -100)
                    return -100;
                return affinity;
            }
        }
        #endregion
        #region Methods
        public CalculatorUI()
        {
            InitializeComponent();
            UpdateEvent = (sender, args) => UpdateValues(sender, args);
        }
        private void InitControls()
        {
            #region Adding Events
            WeaponSelectDropdownBox.SelectedIndexChanged += UpdateEvent;
            SharpnessDropdownBox.SelectedIndexChanged += UpdateEvent;

            AttackBoostDropBox.SelectedIndexChanged += UpdateEvent;
            CriticalEyeDropBox.SelectedIndexChanged += UpdateEvent;
            WeaknessExploitDropBox.SelectedIndexChanged += UpdateEvent;
            HeroicsDropBox.SelectedIndexChanged += UpdateEvent;
            ResentmentDropBox.SelectedIndexChanged += UpdateEvent;
            PeekPerformDropBox.SelectedIndexChanged += UpdateEvent;
            CriticalBoostDropBox.SelectedIndexChanged += UpdateEvent;
            CharmsDropDown.SelectedIndexChanged += UpdateEvent;
            FelyneFoodDropBox.SelectedIndexChanged += UpdateEvent;
            DemonDrugDropBox.SelectedIndexChanged += UpdateEvent;
            SeedPillDropBox.SelectedIndexChanged += UpdateEvent;

            TrueRaw.ValueChanged += UpdateEvent;
            FakeRaw.ValueChanged += UpdateEvent;
            ElementalDamage.ValueChanged += UpdateEvent;
            NaturalAffinity.ValueChanged += UpdateEvent;
            HitzoneModifier.ValueChanged += UpdateEvent;
            ElementalHitzoneModifier.ValueChanged += UpdateEvent;

            ShowModToggle.CheckedChanged += UpdateEvent;
            UseAffinityToggle.CheckedChanged += UpdateEvent;
            ElementLessBonusBox.CheckedChanged += UpdateEvent;
            #endregion
            #region Populating DropDowns
            WeaponSelectDropdownBox.Items.AddRange(Enum.GetValues(typeof(WeaponClass)).Cast<object>().ToArray());
            WeaponSelectDropdownBox.SelectedIndex = 0;

            SharpnessDropdownBox.Items.AddRange(Enum.GetValues(typeof(SharpnessColor)).Cast<object>().ToArray());
            SharpnessDropdownBox.SelectedIndex = 2;

            AttackBoostDropBox.Items.AddRange(Enum.GetValues(typeof(AttackBoost)).Cast<object>().ToArray());
            AttackBoostDropBox.SelectedIndex = 0;

            CriticalEyeDropBox.Items.AddRange(Enum.GetValues(typeof(CriticalEye)).Cast<object>().ToArray());
            CriticalEyeDropBox.SelectedIndex = 0;

            WeaknessExploitDropBox.Items.AddRange(Enum.GetValues(typeof(WeaknessExploit)).Cast<object>().ToArray());
            WeaknessExploitDropBox.SelectedIndex = 0;

            HeroicsDropBox.Items.AddRange(Enum.GetValues(typeof(Heroics)).Cast<object>().ToArray());
            HeroicsDropBox.SelectedIndex = 0;

            ResentmentDropBox.Items.AddRange(Enum.GetValues(typeof(Resentment)).Cast<object>().ToArray());
            ResentmentDropBox.SelectedIndex = 0;

            PeekPerformDropBox.Items.AddRange(Enum.GetValues(typeof(PeakPerformance)).Cast<object>().ToArray());
            PeekPerformDropBox.SelectedIndex = 0;

            CriticalBoostDropBox.Items.AddRange(Enum.GetValues(typeof(CriticalBoost)).Cast<object>().ToArray());
            CriticalBoostDropBox.SelectedIndex = 0;

            CharmsDropDown.Items.AddRange(Enum.GetValues(typeof(PowerCharms)).Cast<object>().ToArray());
            CharmsDropDown.SelectedIndex = 0;

            FelyneFoodDropBox.Items.AddRange(Enum.GetValues(typeof(FelyneFood)).Cast<object>().ToArray());
            FelyneFoodDropBox.SelectedIndex = 0;

            DemonDrugDropBox.Items.AddRange(Enum.GetValues(typeof(DemonDrugs)).Cast<object>().ToArray());
            DemonDrugDropBox.SelectedIndex = 0;

            SeedPillDropBox.Items.AddRange(Enum.GetValues(typeof(SeedPill)).Cast<object>().ToArray());
            SeedPillDropBox.SelectedIndex = 0;
            #endregion
            #region Setting Misc Fields
            TrueRaw.Value = 100;
            MotionValuePanel.VerticalScroll.Visible = true;
            MotionValueBox.Parent = MotionValuePanel;
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        /// <summary>
        /// Updates the UI with new Motion Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateValues(object sender, EventArgs e)
        {
            if (sender == TrueRaw || sender == WeaponSelectDropdownBox)
            {
                FakeRaw.ValueChanged -= UpdateEvent;
                FakeRaw.Value = (int)(TrueRaw.Value * CurrentWeaponModifier);
                FakeRaw.ValueChanged += UpdateEvent;
            }
            else if (sender == FakeRaw)
            {
                TrueRaw.ValueChanged -= UpdateEvent;
                TrueRaw.Value = (int)(FakeRaw.Value / CurrentWeaponModifier);
                TrueRaw.ValueChanged += UpdateEvent;
            }
            MotionValueBox.Text = CurrentWeaponMotionValues;
            WeaponClassModifierLabel.Text = CurrentWeaponModifier.ToString();
            SharpnessModifierLabel.Text = CurrentRawSharpnessModifier.ToString();
            FinalElemental.Text = ((int)FinalElementalDamage).ToString();
            FinalAffinity.Text = TotalAffinity.ToString();
            FinalRawValueLabel.Text = ((int)FinalRaw).ToString();
        }
        #endregion
    }
   
}
