namespace Rengoku_sAttackSpreadSheet
{
    partial class CalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorUI));
            this.MotionValueTitleBar = new System.Windows.Forms.Label();
            this.MotionValueBox = new System.Windows.Forms.Label();
            this.WeaponSelectDropdownBox = new System.Windows.Forms.ComboBox();
            this.WeaponClassTitle = new System.Windows.Forms.Label();
            this.WeaponClassModifierLabel = new System.Windows.Forms.Label();
            this.TrueRaw = new System.Windows.Forms.NumericUpDown();
            this.TrueRawLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FakeRaw = new System.Windows.Forms.NumericUpDown();
            this.SharpnessDropdownBox = new System.Windows.Forms.ComboBox();
            this.SharpnessModifierLabel = new System.Windows.Forms.Label();
            this.SharpnessModifierTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalRawValueLabel = new System.Windows.Forms.Label();
            this.TrueRawTip = new System.Windows.Forms.ToolTip(this.components);
            this.FakeRawTip = new System.Windows.Forms.ToolTip(this.components);
            this.MotionValue = new System.Windows.Forms.ToolTip(this.components);
            this.ShowModToggle = new System.Windows.Forms.CheckBox();
            this.ShowModTip = new System.Windows.Forms.ToolTip(this.components);
            this.NaturalAffinityLabel = new System.Windows.Forms.Label();
            this.NaturalAffinity = new System.Windows.Forms.NumericUpDown();
            this.NaturalAffinityTip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AttackBoostDropBox = new System.Windows.Forms.ComboBox();
            this.CriticalEyeDropBox = new System.Windows.Forms.ComboBox();
            this.WeaknessExploitDropBox = new System.Windows.Forms.ComboBox();
            this.HeroicsDropBox = new System.Windows.Forms.ComboBox();
            this.CharmsDropDown = new System.Windows.Forms.ComboBox();
            this.ResentmentDropBox = new System.Windows.Forms.ComboBox();
            this.ResentmentLabel = new System.Windows.Forms.Label();
            this.FinalAffinity = new System.Windows.Forms.Label();
            this.FinalAffinityLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HitzoneModifier = new System.Windows.Forms.NumericUpDown();
            this.HitZoneTips = new System.Windows.Forms.ToolTip(this.components);
            this.WeaponModTip = new System.Windows.Forms.ToolTip(this.components);
            this.AttackBoostTip = new System.Windows.Forms.ToolTip(this.components);
            this.CriticalEyeTip = new System.Windows.Forms.ToolTip(this.components);
            this.WeaknessExploitTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeroicsTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResentmentTip = new System.Windows.Forms.ToolTip(this.components);
            this.FinalRawTip = new System.Windows.Forms.ToolTip(this.components);
            this.CriticalBoostDropBox = new System.Windows.Forms.ComboBox();
            this.CriticalBoostLabel = new System.Windows.Forms.Label();
            this.CharmsTip = new System.Windows.Forms.ToolTip(this.components);
            this.CriticalBoostTips = new System.Windows.Forms.ToolTip(this.components);
            this.MotionValuePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TrueRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakeRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaturalAffinity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitzoneModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // MotionValueTitleBar
            // 
            this.MotionValueTitleBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MotionValueTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotionValueTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotionValueTitleBar.Location = new System.Drawing.Point(225, 9);
            this.MotionValueTitleBar.Name = "MotionValueTitleBar";
            this.MotionValueTitleBar.Size = new System.Drawing.Size(376, 27);
            this.MotionValueTitleBar.TabIndex = 1;
            this.MotionValueTitleBar.Text = "MotionValues";
            this.MotionValueTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MotionValue.SetToolTip(this.MotionValueTitleBar, "The amount of damage each weapon swing does.\r\nThe Final Raw is used here.\r\n\r\nExpe" +
        "ct a variance of ~4% due to rounding.\r\nAffinity generates an Expected Value so t" +
        "here may be some inaccuracies.");
            // 
            // MotionValueBox
            // 
            this.MotionValueBox.AutoSize = true;
            this.MotionValueBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MotionValueBox.Location = new System.Drawing.Point(0, 0);
            this.MotionValueBox.Name = "MotionValueBox";
            this.MotionValueBox.Size = new System.Drawing.Size(0, 13);
            this.MotionValueBox.TabIndex = 3;
            // 
            // WeaponSelectDropdownBox
            // 
            this.WeaponSelectDropdownBox.CausesValidation = false;
            this.WeaponSelectDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeaponSelectDropdownBox.FormattingEnabled = true;
            this.WeaponSelectDropdownBox.Location = new System.Drawing.Point(5, 9);
            this.WeaponSelectDropdownBox.Name = "WeaponSelectDropdownBox";
            this.WeaponSelectDropdownBox.Size = new System.Drawing.Size(214, 21);
            this.WeaponSelectDropdownBox.TabIndex = 4;
            // 
            // WeaponClassTitle
            // 
            this.WeaponClassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponClassTitle.Location = new System.Drawing.Point(2, 34);
            this.WeaponClassTitle.Name = "WeaponClassTitle";
            this.WeaponClassTitle.Size = new System.Drawing.Size(129, 18);
            this.WeaponClassTitle.TabIndex = 5;
            this.WeaponClassTitle.Text = "WeaponClass Modifier";
            this.WeaponClassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeaponModTip.SetToolTip(this.WeaponClassTitle, "The True Raw was multiplied by this number to create the Fake Raw values displaye" +
        "d in Game.");
            // 
            // WeaponClassModifierLabel
            // 
            this.WeaponClassModifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponClassModifierLabel.Location = new System.Drawing.Point(122, 33);
            this.WeaponClassModifierLabel.Name = "WeaponClassModifierLabel";
            this.WeaponClassModifierLabel.Size = new System.Drawing.Size(97, 18);
            this.WeaponClassModifierLabel.TabIndex = 6;
            this.WeaponClassModifierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrueRaw
            // 
            this.TrueRaw.Location = new System.Drawing.Point(125, 105);
            this.TrueRaw.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TrueRaw.Name = "TrueRaw";
            this.TrueRaw.Size = new System.Drawing.Size(94, 20);
            this.TrueRaw.TabIndex = 7;
            this.TrueRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrueRaw.ThousandsSeparator = true;
            // 
            // TrueRawLabel
            // 
            this.TrueRawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueRawLabel.Location = new System.Drawing.Point(2, 105);
            this.TrueRawLabel.Name = "TrueRawLabel";
            this.TrueRawLabel.Size = new System.Drawing.Size(117, 18);
            this.TrueRawLabel.TabIndex = 8;
            this.TrueRawLabel.Text = "True Raw Damage";
            this.TrueRawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrueRawTip.SetToolTip(this.TrueRawLabel, "Value the Game actually uses.\r\nUse this if you already know the truth!");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fake Raw Damage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FakeRawTip.SetToolTip(this.label1, "Value seen in Equipment Info.\r\nReal value is obtained after dividing by the Weapo" +
        "n class modifier");
            // 
            // FakeRaw
            // 
            this.FakeRaw.Location = new System.Drawing.Point(125, 134);
            this.FakeRaw.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FakeRaw.Name = "FakeRaw";
            this.FakeRaw.Size = new System.Drawing.Size(94, 20);
            this.FakeRaw.TabIndex = 9;
            this.FakeRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FakeRaw.ThousandsSeparator = true;
            // 
            // SharpnessDropdownBox
            // 
            this.SharpnessDropdownBox.CausesValidation = false;
            this.SharpnessDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SharpnessDropdownBox.FormattingEnabled = true;
            this.SharpnessDropdownBox.Location = new System.Drawing.Point(5, 60);
            this.SharpnessDropdownBox.Name = "SharpnessDropdownBox";
            this.SharpnessDropdownBox.Size = new System.Drawing.Size(214, 21);
            this.SharpnessDropdownBox.TabIndex = 11;
            // 
            // SharpnessModifierLabel
            // 
            this.SharpnessModifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharpnessModifierLabel.Location = new System.Drawing.Point(122, 83);
            this.SharpnessModifierLabel.Name = "SharpnessModifierLabel";
            this.SharpnessModifierLabel.Size = new System.Drawing.Size(97, 18);
            this.SharpnessModifierLabel.TabIndex = 13;
            this.SharpnessModifierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SharpnessModifierTitle
            // 
            this.SharpnessModifierTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharpnessModifierTitle.Location = new System.Drawing.Point(2, 84);
            this.SharpnessModifierTitle.Name = "SharpnessModifierTitle";
            this.SharpnessModifierTitle.Size = new System.Drawing.Size(129, 18);
            this.SharpnessModifierTitle.TabIndex = 12;
            this.SharpnessModifierTitle.Text = "Sharpness Modifier";
            this.SharpnessModifierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Final Raw";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinalRawTip.SetToolTip(this.label2, "Final Raw Damage Value with all Modifiers applied including Sharpness.");
            // 
            // FinalRawValueLabel
            // 
            this.FinalRawValueLabel.CausesValidation = false;
            this.FinalRawValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalRawValueLabel.Location = new System.Drawing.Point(103, 487);
            this.FinalRawValueLabel.Name = "FinalRawValueLabel";
            this.FinalRawValueLabel.Size = new System.Drawing.Size(117, 18);
            this.FinalRawValueLabel.TabIndex = 16;
            this.FinalRawValueLabel.Text = "0";
            this.FinalRawValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowModToggle
            // 
            this.ShowModToggle.Location = new System.Drawing.Point(512, 13);
            this.ShowModToggle.Name = "ShowModToggle";
            this.ShowModToggle.Size = new System.Drawing.Size(81, 17);
            this.ShowModToggle.TabIndex = 17;
            this.ShowModToggle.Text = "Show Mod";
            this.ShowModTip.SetToolTip(this.ShowModToggle, "If Checked, the original values used for calculations will be shown.\r\nUseful for " +
        "the curious.\r\nJust set Sharpness to Yellow and Turn off all Skill Modifiers!");
            this.ShowModToggle.UseVisualStyleBackColor = true;
            // 
            // NaturalAffinityLabel
            // 
            this.NaturalAffinityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaturalAffinityLabel.Location = new System.Drawing.Point(2, 164);
            this.NaturalAffinityLabel.Name = "NaturalAffinityLabel";
            this.NaturalAffinityLabel.Size = new System.Drawing.Size(117, 18);
            this.NaturalAffinityLabel.TabIndex = 19;
            this.NaturalAffinityLabel.Text = "Natural Affinity";
            this.NaturalAffinityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NaturalAffinityTip.SetToolTip(this.NaturalAffinityLabel, "Affinity seen in Equipment Info.");
            // 
            // NaturalAffinity
            // 
            this.NaturalAffinity.Location = new System.Drawing.Point(125, 164);
            this.NaturalAffinity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NaturalAffinity.Name = "NaturalAffinity";
            this.NaturalAffinity.Size = new System.Drawing.Size(94, 20);
            this.NaturalAffinity.TabIndex = 18;
            this.NaturalAffinity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Skill Modifiers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Attack Boost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttackBoostTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Critical Eye";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CriticalEyeTip.SetToolTip(this.label5, "Level 1: +3% Affinity\r\nLevel 2: +6% Affinity\r\nLevel 3: +10% Affinity\r\nLevel 4: +1" +
        "5% Affinity\r\nLevel 5: +20% Affinity\r\nLevel 6: +25% Affinity\r\nLevel 7: +30% Affin" +
        "ity");
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Weakness Exploit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeaknessExploitTip.SetToolTip(this.label6, "Level 1: Attacks that hit weak spots have 15% increased affinity.\r\nLevel 2: Attac" +
        "ks that hit weak spots have 30% increased affinity.\r\nLevel 3: Attacks that hit w" +
        "eak spots have 50% increased affinity.");
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Heroics";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeroicsTip.SetToolTip(this.label7, "When Health is Lower or Equal to 35 percent:\r\nLevel 1: +5% Attack Power\r\nLevel 2:" +
        " +10% Attack Power\r\nLevel 3: +15% Attack Power\r\nLevel 4: +20% Attack Power\r\nLeve" +
        "l 5: +30% Attack Power");
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Charms";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CharmsTip.SetToolTip(this.label8, "Uses True Raw:\r\nPowerCharm: +~6 Attack Power\r\nPowerTalon: +~8 Attack Power\r\nBoth " +
        "Charms Used: +15 Attack Power");
            // 
            // AttackBoostDropBox
            // 
            this.AttackBoostDropBox.CausesValidation = false;
            this.AttackBoostDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttackBoostDropBox.FormattingEnabled = true;
            this.AttackBoostDropBox.Location = new System.Drawing.Point(125, 218);
            this.AttackBoostDropBox.Name = "AttackBoostDropBox";
            this.AttackBoostDropBox.Size = new System.Drawing.Size(94, 21);
            this.AttackBoostDropBox.TabIndex = 23;
            // 
            // CriticalEyeDropBox
            // 
            this.CriticalEyeDropBox.CausesValidation = false;
            this.CriticalEyeDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CriticalEyeDropBox.FormattingEnabled = true;
            this.CriticalEyeDropBox.Location = new System.Drawing.Point(125, 251);
            this.CriticalEyeDropBox.Name = "CriticalEyeDropBox";
            this.CriticalEyeDropBox.Size = new System.Drawing.Size(94, 21);
            this.CriticalEyeDropBox.TabIndex = 25;
            // 
            // WeaknessExploitDropBox
            // 
            this.WeaknessExploitDropBox.CausesValidation = false;
            this.WeaknessExploitDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeaknessExploitDropBox.FormattingEnabled = true;
            this.WeaknessExploitDropBox.Location = new System.Drawing.Point(125, 283);
            this.WeaknessExploitDropBox.Name = "WeaknessExploitDropBox";
            this.WeaknessExploitDropBox.Size = new System.Drawing.Size(94, 21);
            this.WeaknessExploitDropBox.TabIndex = 27;
            // 
            // HeroicsDropBox
            // 
            this.HeroicsDropBox.CausesValidation = false;
            this.HeroicsDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeroicsDropBox.FormattingEnabled = true;
            this.HeroicsDropBox.Location = new System.Drawing.Point(126, 315);
            this.HeroicsDropBox.Name = "HeroicsDropBox";
            this.HeroicsDropBox.Size = new System.Drawing.Size(94, 21);
            this.HeroicsDropBox.TabIndex = 29;
            // 
            // CharmsDropDown
            // 
            this.CharmsDropDown.CausesValidation = false;
            this.CharmsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharmsDropDown.FormattingEnabled = true;
            this.CharmsDropDown.Location = new System.Drawing.Point(126, 409);
            this.CharmsDropDown.Name = "CharmsDropDown";
            this.CharmsDropDown.Size = new System.Drawing.Size(94, 21);
            this.CharmsDropDown.TabIndex = 31;
            // 
            // ResentmentDropBox
            // 
            this.ResentmentDropBox.CausesValidation = false;
            this.ResentmentDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResentmentDropBox.FormattingEnabled = true;
            this.ResentmentDropBox.Location = new System.Drawing.Point(126, 344);
            this.ResentmentDropBox.Name = "ResentmentDropBox";
            this.ResentmentDropBox.Size = new System.Drawing.Size(94, 21);
            this.ResentmentDropBox.TabIndex = 33;
            // 
            // ResentmentLabel
            // 
            this.ResentmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResentmentLabel.Location = new System.Drawing.Point(3, 344);
            this.ResentmentLabel.Name = "ResentmentLabel";
            this.ResentmentLabel.Size = new System.Drawing.Size(117, 18);
            this.ResentmentLabel.TabIndex = 32;
            this.ResentmentLabel.Text = "Resentment";
            this.ResentmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResentmentTip.SetToolTip(this.ResentmentLabel, "When you have Red Health:\r\nLevel 1: +5 Attack Power\r\nLevel 2: +10 Attack Power\r\nL" +
        "evel 3: +15 Attack Power\r\nLevel 4: +20 Attack Power\r\nLevel 5: +25 Attack Power");
            // 
            // FinalAffinity
            // 
            this.FinalAffinity.CausesValidation = false;
            this.FinalAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAffinity.Location = new System.Drawing.Point(103, 469);
            this.FinalAffinity.Name = "FinalAffinity";
            this.FinalAffinity.Size = new System.Drawing.Size(117, 18);
            this.FinalAffinity.TabIndex = 35;
            this.FinalAffinity.Text = "0";
            this.FinalAffinity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalAffinityLabel
            // 
            this.FinalAffinityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAffinityLabel.Location = new System.Drawing.Point(2, 469);
            this.FinalAffinityLabel.Name = "FinalAffinityLabel";
            this.FinalAffinityLabel.Size = new System.Drawing.Size(94, 18);
            this.FinalAffinityLabel.TabIndex = 34;
            this.FinalAffinityLabel.Text = "Final Affinity";
            this.FinalAffinityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Hitzone Modifier";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HitZoneTips.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // HitzoneModifier
            // 
            this.HitzoneModifier.Location = new System.Drawing.Point(126, 452);
            this.HitzoneModifier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HitzoneModifier.Name = "HitzoneModifier";
            this.HitzoneModifier.Size = new System.Drawing.Size(94, 20);
            this.HitzoneModifier.TabIndex = 36;
            this.HitzoneModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HitzoneModifier.ThousandsSeparator = true;
            this.HitzoneModifier.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CriticalBoostDropBox
            // 
            this.CriticalBoostDropBox.CausesValidation = false;
            this.CriticalBoostDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CriticalBoostDropBox.FormattingEnabled = true;
            this.CriticalBoostDropBox.Location = new System.Drawing.Point(125, 377);
            this.CriticalBoostDropBox.Name = "CriticalBoostDropBox";
            this.CriticalBoostDropBox.Size = new System.Drawing.Size(94, 21);
            this.CriticalBoostDropBox.TabIndex = 39;
            // 
            // CriticalBoostLabel
            // 
            this.CriticalBoostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalBoostLabel.Location = new System.Drawing.Point(2, 377);
            this.CriticalBoostLabel.Name = "CriticalBoostLabel";
            this.CriticalBoostLabel.Size = new System.Drawing.Size(117, 18);
            this.CriticalBoostLabel.TabIndex = 38;
            this.CriticalBoostLabel.Text = "Critical Boost";
            this.CriticalBoostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CriticalBoostTips.SetToolTip(this.CriticalBoostLabel, "Instead of 25% extra damage from Critical Hits:\r\n\r\nLevel 1: 30% extra damage from" +
        " Critical Hits.\r\nLevel 2: 35% extra damage from Critical Hits.\r\nLevel 3: 40% ext" +
        "ra damage from Critical Hits.\r\n");
            // 
            // MotionValuePanel
            // 
            this.MotionValuePanel.AutoScroll = true;
            this.MotionValuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotionValuePanel.Location = new System.Drawing.Point(225, 36);
            this.MotionValuePanel.Name = "MotionValuePanel";
            this.MotionValuePanel.Size = new System.Drawing.Size(376, 471);
            this.MotionValuePanel.TabIndex = 40;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(605, 508);
            this.Controls.Add(this.CriticalBoostDropBox);
            this.Controls.Add(this.CriticalBoostLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HitzoneModifier);
            this.Controls.Add(this.FinalAffinity);
            this.Controls.Add(this.FinalAffinityLabel);
            this.Controls.Add(this.ResentmentDropBox);
            this.Controls.Add(this.ResentmentLabel);
            this.Controls.Add(this.CharmsDropDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HeroicsDropBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WeaknessExploitDropBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CriticalEyeDropBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AttackBoostDropBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NaturalAffinityLabel);
            this.Controls.Add(this.NaturalAffinity);
            this.Controls.Add(this.ShowModToggle);
            this.Controls.Add(this.FinalRawValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SharpnessModifierLabel);
            this.Controls.Add(this.SharpnessModifierTitle);
            this.Controls.Add(this.SharpnessDropdownBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FakeRaw);
            this.Controls.Add(this.TrueRawLabel);
            this.Controls.Add(this.TrueRaw);
            this.Controls.Add(this.WeaponClassModifierLabel);
            this.Controls.Add(this.WeaponClassTitle);
            this.Controls.Add(this.WeaponSelectDropdownBox);
            this.Controls.Add(this.MotionValueTitleBar);
            this.Controls.Add(this.MotionValueBox);
            this.Controls.Add(this.MotionValuePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 547);
            this.MinimumSize = new System.Drawing.Size(621, 547);
            this.Name = "CalculatorUI";
            this.Text = "Rengoku\'sAttackSpreadSheet";
            this.MotionValue.SetToolTip(this, "Damage of each move during an attack per attack animation.\r\nTHIS is what seperate" +
        "s weapons in terms of DPS.");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrueRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakeRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaturalAffinity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitzoneModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MotionValueTitleBar;
        private System.Windows.Forms.Label MotionValueBox;
        private System.Windows.Forms.ComboBox WeaponSelectDropdownBox;
        private System.Windows.Forms.Label WeaponClassTitle;
        private System.Windows.Forms.Label WeaponClassModifierLabel;
        private System.Windows.Forms.NumericUpDown TrueRaw;
        private System.Windows.Forms.Label TrueRawLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FakeRaw;
        private System.Windows.Forms.ComboBox SharpnessDropdownBox;
        private System.Windows.Forms.Label SharpnessModifierLabel;
        private System.Windows.Forms.Label SharpnessModifierTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FinalRawValueLabel;
        private System.Windows.Forms.ToolTip TrueRawTip;
        private System.Windows.Forms.ToolTip FakeRawTip;
        private System.Windows.Forms.ToolTip MotionValue;
        private System.Windows.Forms.CheckBox ShowModToggle;
        private System.Windows.Forms.ToolTip ShowModTip;
        private System.Windows.Forms.Label NaturalAffinityLabel;
        private System.Windows.Forms.ToolTip NaturalAffinityTip;
        private System.Windows.Forms.NumericUpDown NaturalAffinity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AttackBoostDropBox;
        private System.Windows.Forms.ComboBox CriticalEyeDropBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WeaknessExploitDropBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox HeroicsDropBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CharmsDropDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ResentmentDropBox;
        private System.Windows.Forms.Label ResentmentLabel;
        private System.Windows.Forms.Label FinalAffinity;
        private System.Windows.Forms.Label FinalAffinityLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown HitzoneModifier;
        private System.Windows.Forms.ToolTip HitZoneTips;
        private System.Windows.Forms.ToolTip WeaponModTip;
        private System.Windows.Forms.ToolTip AttackBoostTip;
        private System.Windows.Forms.ToolTip CriticalEyeTip;
        private System.Windows.Forms.ToolTip WeaknessExploitTip;
        private System.Windows.Forms.ToolTip HeroicsTip;
        private System.Windows.Forms.ToolTip ResentmentTip;
        private System.Windows.Forms.ToolTip FinalRawTip;
        private System.Windows.Forms.ComboBox CriticalBoostDropBox;
        private System.Windows.Forms.Label CriticalBoostLabel;
        private System.Windows.Forms.ToolTip CharmsTip;
        private System.Windows.Forms.ToolTip CriticalBoostTips;
        private System.Windows.Forms.Panel MotionValuePanel;
    }
}

