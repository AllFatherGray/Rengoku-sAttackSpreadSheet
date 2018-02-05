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
        #region Properties
        private WeaponClass CurrentWeapon => (WeaponClass)WeaponSelectDropdownBox.SelectedIndex;
        private SharpnessColor CurrentSharpness => (SharpnessColor)SharpnessDropdownBox.SelectedIndex;

        // Modifiers
        private decimal CurrentSharpnessModifier => WeaponDataBase.GetSharpnessModifier(CurrentSharpness);
        private decimal CurrentWeaponModifier => WeaponDataBase.GetWeaponModifier(CurrentWeapon);
        private decimal CurrentHitZoneModifier => HitzoneModifier.Value / 100.0M;

        // Raw Attack Related Bonuses
        private decimal HeroicsBonus => WeaponDataBase.GetHeroicsModifier((Heroics)HeroicsDropBox.SelectedIndex);
        private int ResentmentBonus => WeaponDataBase.GetAttackModifier((Resentment)ResentmentDropBox.SelectedIndex);
        private int AttackBonus => WeaponDataBase.GetAttackModifier((AttackBoost)AttackBoostDropBox.SelectedIndex);
        private int CharmBonus => WeaponDataBase.GetAttackModifier((PowerCharms)CharmsDropDown.SelectedIndex);

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
                decimal tempFinalRaw = FinalRaw;
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

                                        words[i] = ((int)Math.Ceiling(MotionValue * tempFinalRaw * CurrentHitZoneModifier)).ToString() + (CurrentWord.Last() == '>' ? ' ' : CurrentWord.Last());
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
        private decimal FinalRaw
        {
            get
            {
                // Using Current User Values or A default value to look at Motion Values?
                decimal CurrentValue = !ShowModToggle.Checked ? TrueRaw.Value : 100;

                // Add Misc Attack Bonus
                CurrentValue += (ResentmentBonus + AttackBonus + CharmBonus);

                // Add Heroics Bonus
                CurrentValue += Math.Ceiling((CurrentValue * HeroicsBonus) / 100);

                // Add Heroics Bonus
                CurrentValue = Math.Ceiling((CurrentValue * CurrentSharpnessModifier));

                // Affinity Check
                if(TotalAffinity > 0)
                {
                    return (int)((CurrentValue * ((100m - TotalAffinity) / 100m))) + (int)((CurrentValue * (((TotalAffinity) / 100m)) * CritBoostBonus));
                }
                else if(TotalAffinity < 0)
                {
                    return (int)((CurrentValue * ((100m + TotalAffinity) / 100m))) + (int)((CurrentValue * (((-TotalAffinity) / 100m)) * MHConstants.FeebleHit));
                }

                return (CurrentValue);
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
        }
        private void InitControls()
        {
            #region Adding Events
            WeaponSelectDropdownBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            SharpnessDropdownBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);

            AttackBoostDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            CriticalEyeDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            WeaknessExploitDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            HeroicsDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            ResentmentDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            CriticalBoostDropBox.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);
            CharmsDropDown.SelectedIndexChanged += (sender, args) => UpdateValues(sender, args);

            TrueRaw.ValueChanged += (sender, args) => UpdateValues(sender, args);
            FakeRaw.ValueChanged += (sender, args) => UpdateValues(sender, args);
            NaturalAffinity.ValueChanged += (sender, args) => UpdateValues(sender, args);
            HitzoneModifier.ValueChanged += (sender, args) => UpdateValues(sender, args);

            ShowModToggle.CheckedChanged += (sender, args) => UpdateValues(sender, args);

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

            CriticalBoostDropBox.Items.AddRange(Enum.GetValues(typeof(CriticalBoost)).Cast<object>().ToArray());
            CriticalBoostDropBox.SelectedIndex = 0;

            CharmsDropDown.Items.AddRange(Enum.GetValues(typeof(PowerCharms)).Cast<object>().ToArray());
            CharmsDropDown.SelectedIndex = 0;
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
            MotionValueBox.Text = CurrentWeaponMotionValues;
            WeaponClassModifierLabel.Text = CurrentWeaponModifier.ToString();
            SharpnessModifierLabel.Text = CurrentSharpnessModifier.ToString();
            
            if(sender == TrueRaw)
            {
                FakeRaw.Enabled = false;
                FakeRaw.Value = (int)Math.Round(TrueRaw.Value * CurrentWeaponModifier);
                FakeRaw.Enabled = true;
            }
            else if (sender == FakeRaw)
            {
                TrueRaw.Enabled = false;
                TrueRaw.Value = (int)Math.Round(FakeRaw.Value / CurrentWeaponModifier);
                TrueRaw.Enabled = true;
            }
            else
            {
                FakeRaw.Value = (int)Math.Round(TrueRaw.Value * CurrentWeaponModifier);
                TrueRaw.Value = (int)Math.Round(FakeRaw.Value / CurrentWeaponModifier);
            }
            FinalAffinity.Text = TotalAffinity.ToString();
            FinalRawValueLabel.Text = ((int)FinalRaw).ToString();
        }
        #endregion
    }
   
}
