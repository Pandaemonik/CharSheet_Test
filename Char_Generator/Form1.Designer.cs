﻿namespace Char_Generator
{
    partial class charGenMain
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
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemCreateCharacter = new System.Windows.Forms.ToolStripMenuItem();
			this.addExpirienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.tabPageDisplauInLabel = new System.Windows.Forms.TabPage();
			this.showCharacter = new System.Windows.Forms.Button();
			this.showCharacteristics = new System.Windows.Forms.Button();
			this.showAptitudes = new System.Windows.Forms.Button();
			this.showTalents = new System.Windows.Forms.Button();
			this.showSkills = new System.Windows.Forms.Button();
			this.richTextBoxCurrentlyKnown = new System.Windows.Forms.RichTextBox();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBoxWoundsCurrent = new System.Windows.Forms.RichTextBox();
			this.labelWoundsMax = new System.Windows.Forms.Label();
			this.textBoxFateCurrent = new System.Windows.Forms.RichTextBox();
			this.labelFateMax = new System.Windows.Forms.Label();
			this.labelFate = new System.Windows.Forms.Label();
			this.textBoxCorruption = new System.Windows.Forms.RichTextBox();
			this.labelCorruption = new System.Windows.Forms.Label();
			this.textBoxInsanity = new System.Windows.Forms.RichTextBox();
			this.labelInanity = new System.Windows.Forms.Label();
			this.labelXpSpent = new System.Windows.Forms.Label();
			this.labelXpLeft = new System.Windows.Forms.Label();
			this.labelWounds = new System.Windows.Forms.Label();
			this.buttonSpendXp = new System.Windows.Forms.Button();
			this.textBoxXpLeft = new System.Windows.Forms.RichTextBox();
			this.textBoxXpSpent = new System.Windows.Forms.RichTextBox();
			this.textBoxName = new System.Windows.Forms.RichTextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.listBoxTalentDetails = new System.Windows.Forms.ListBox();
			this.textBoxTalents = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxSpecialRules = new System.Windows.Forms.RichTextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBoxAptitudes = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxSkills = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxCharacteristics = new System.Windows.Forms.RichTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonChangeDescription = new System.Windows.Forms.Button();
			this.textBoxRegiment = new System.Windows.Forms.RichTextBox();
			this.textBoxSpecialty = new System.Windows.Forms.RichTextBox();
			this.textBoxDescription = new System.Windows.Forms.RichTextBox();
			this.textBoxDemeanor = new System.Windows.Forms.RichTextBox();
			this.labelRegiment = new System.Windows.Forms.Label();
			this.labelSpecialty = new System.Windows.Forms.Label();
			this.labelDemeanour = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.menuStripMain.SuspendLayout();
			this.tabPageDisplauInLabel.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterToolStripMenuItem,
            this.importCharacterToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// saveCharacterToolStripMenuItem
			// 
			this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
			this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.saveCharacterToolStripMenuItem.Text = "Save Character";
			this.saveCharacterToolStripMenuItem.Click += new System.EventHandler(this.exportCharacterToolStripMenuItem_Click);
			// 
			// importCharacterToolStripMenuItem
			// 
			this.importCharacterToolStripMenuItem.Name = "importCharacterToolStripMenuItem";
			this.importCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.importCharacterToolStripMenuItem.Text = "Load Character";
			this.importCharacterToolStripMenuItem.Click += new System.EventHandler(this.importCharacterToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// characterToolStripMenuItem
			// 
			this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCreateCharacter,
            this.addExpirienceToolStripMenuItem});
			this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
			this.characterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.characterToolStripMenuItem.Text = "&Character";
			// 
			// MenuItemCreateCharacter
			// 
			this.MenuItemCreateCharacter.Name = "MenuItemCreateCharacter";
			this.MenuItemCreateCharacter.Size = new System.Drawing.Size(155, 22);
			this.MenuItemCreateCharacter.Text = "Create";
			this.MenuItemCreateCharacter.Click += new System.EventHandler(this.MenuItemCreateCharacter_Click);
			// 
			// addExpirienceToolStripMenuItem
			// 
			this.addExpirienceToolStripMenuItem.Name = "addExpirienceToolStripMenuItem";
			this.addExpirienceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.addExpirienceToolStripMenuItem.Text = "Add Experience";
			this.addExpirienceToolStripMenuItem.Click += new System.EventHandler(this.addExpirienceToolStripMenuItem_Click);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.characterToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(990, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "MainMenuStrip";
			// 
			// tabPageDisplauInLabel
			// 
			this.tabPageDisplauInLabel.Controls.Add(this.showCharacter);
			this.tabPageDisplauInLabel.Controls.Add(this.showCharacteristics);
			this.tabPageDisplauInLabel.Controls.Add(this.showAptitudes);
			this.tabPageDisplauInLabel.Controls.Add(this.showTalents);
			this.tabPageDisplauInLabel.Controls.Add(this.showSkills);
			this.tabPageDisplauInLabel.Controls.Add(this.richTextBoxCurrentlyKnown);
			this.tabPageDisplauInLabel.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisplauInLabel.Name = "tabPageDisplauInLabel";
			this.tabPageDisplauInLabel.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisplauInLabel.Size = new System.Drawing.Size(1076, 442);
			this.tabPageDisplauInLabel.TabIndex = 1;
			this.tabPageDisplauInLabel.Text = "Show as Text";
			this.tabPageDisplauInLabel.UseVisualStyleBackColor = true;
			// 
			// showCharacter
			// 
			this.showCharacter.Location = new System.Drawing.Point(8, 386);
			this.showCharacter.Name = "showCharacter";
			this.showCharacter.Size = new System.Drawing.Size(117, 23);
			this.showCharacter.TabIndex = 74;
			this.showCharacter.Text = "Show Character";
			this.showCharacter.UseVisualStyleBackColor = true;
			this.showCharacter.Click += new System.EventHandler(this.showCharacter_Click);
			// 
			// showCharacteristics
			// 
			this.showCharacteristics.Location = new System.Drawing.Point(239, 385);
			this.showCharacteristics.Name = "showCharacteristics";
			this.showCharacteristics.Size = new System.Drawing.Size(117, 25);
			this.showCharacteristics.TabIndex = 61;
			this.showCharacteristics.Text = "Show Characteristics";
			this.showCharacteristics.UseVisualStyleBackColor = true;
			this.showCharacteristics.Click += new System.EventHandler(this.showCharacteristics_Click);
			// 
			// showAptitudes
			// 
			this.showAptitudes.Location = new System.Drawing.Point(460, 385);
			this.showAptitudes.Name = "showAptitudes";
			this.showAptitudes.Size = new System.Drawing.Size(117, 25);
			this.showAptitudes.TabIndex = 60;
			this.showAptitudes.Text = "Show Aptitudes";
			this.showAptitudes.UseVisualStyleBackColor = true;
			this.showAptitudes.Click += new System.EventHandler(this.showAptitudes_Click);
			// 
			// showTalents
			// 
			this.showTalents.Location = new System.Drawing.Point(686, 385);
			this.showTalents.Name = "showTalents";
			this.showTalents.Size = new System.Drawing.Size(117, 25);
			this.showTalents.TabIndex = 59;
			this.showTalents.Text = "Show Talents";
			this.showTalents.UseVisualStyleBackColor = true;
			this.showTalents.Click += new System.EventHandler(this.showTalents_Click);
			// 
			// showSkills
			// 
			this.showSkills.Location = new System.Drawing.Point(857, 385);
			this.showSkills.Name = "showSkills";
			this.showSkills.Size = new System.Drawing.Size(117, 25);
			this.showSkills.TabIndex = 58;
			this.showSkills.Text = "Show Skills";
			this.showSkills.UseVisualStyleBackColor = true;
			this.showSkills.Click += new System.EventHandler(this.showSkills_Click);
			// 
			// richTextBoxCurrentlyKnown
			// 
			this.richTextBoxCurrentlyKnown.Location = new System.Drawing.Point(8, 19);
			this.richTextBoxCurrentlyKnown.Name = "richTextBoxCurrentlyKnown";
			this.richTextBoxCurrentlyKnown.ReadOnly = true;
			this.richTextBoxCurrentlyKnown.Size = new System.Drawing.Size(966, 360);
			this.richTextBoxCurrentlyKnown.TabIndex = 57;
			this.richTextBoxCurrentlyKnown.Text = "";
			// 
			// tabPageMain
			// 
			this.tabPageMain.Controls.Add(this.groupBox6);
			this.tabPageMain.Controls.Add(this.groupBox5);
			this.tabPageMain.Controls.Add(this.groupBox4);
			this.tabPageMain.Controls.Add(this.groupBox3);
			this.tabPageMain.Controls.Add(this.groupBox2);
			this.tabPageMain.Controls.Add(this.groupBox1);
			this.tabPageMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(1076, 442);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "MainTab";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.textBoxWoundsCurrent);
			this.groupBox6.Controls.Add(this.labelWoundsMax);
			this.groupBox6.Controls.Add(this.textBoxFateCurrent);
			this.groupBox6.Controls.Add(this.labelFateMax);
			this.groupBox6.Controls.Add(this.labelFate);
			this.groupBox6.Controls.Add(this.textBoxCorruption);
			this.groupBox6.Controls.Add(this.labelCorruption);
			this.groupBox6.Controls.Add(this.textBoxInsanity);
			this.groupBox6.Controls.Add(this.labelInanity);
			this.groupBox6.Controls.Add(this.labelXpSpent);
			this.groupBox6.Controls.Add(this.labelXpLeft);
			this.groupBox6.Controls.Add(this.labelWounds);
			this.groupBox6.Controls.Add(this.buttonSpendXp);
			this.groupBox6.Controls.Add(this.textBoxXpLeft);
			this.groupBox6.Controls.Add(this.textBoxXpSpent);
			this.groupBox6.Controls.Add(this.textBoxName);
			this.groupBox6.Controls.Add(this.labelName);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox6.Location = new System.Drawing.Point(8, 13);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(263, 173);
			this.groupBox6.TabIndex = 80;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Bio && Info";
			// 
			// textBoxWoundsCurrent
			// 
			this.textBoxWoundsCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxWoundsCurrent.Location = new System.Drawing.Point(146, 117);
			this.textBoxWoundsCurrent.Name = "textBoxWoundsCurrent";
			this.textBoxWoundsCurrent.Size = new System.Drawing.Size(26, 20);
			this.textBoxWoundsCurrent.TabIndex = 89;
			this.textBoxWoundsCurrent.Text = "";
			this.textBoxWoundsCurrent.TextChanged += new System.EventHandler(this.textBoxWounds_TextChanged);
			// 
			// labelWoundsMax
			// 
			this.labelWoundsMax.AutoSize = true;
			this.labelWoundsMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWoundsMax.Location = new System.Drawing.Point(169, 120);
			this.labelWoundsMax.Name = "labelWoundsMax";
			this.labelWoundsMax.Size = new System.Drawing.Size(12, 13);
			this.labelWoundsMax.TabIndex = 148;
			this.labelWoundsMax.Text = "/";
			// 
			// textBoxFateCurrent
			// 
			this.textBoxFateCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFateCurrent.Location = new System.Drawing.Point(146, 78);
			this.textBoxFateCurrent.MaxLength = 2;
			this.textBoxFateCurrent.Name = "textBoxFateCurrent";
			this.textBoxFateCurrent.Size = new System.Drawing.Size(26, 20);
			this.textBoxFateCurrent.TabIndex = 144;
			this.textBoxFateCurrent.Text = "";
			// 
			// labelFateMax
			// 
			this.labelFateMax.AutoSize = true;
			this.labelFateMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFateMax.Location = new System.Drawing.Point(169, 81);
			this.labelFateMax.Name = "labelFateMax";
			this.labelFateMax.Size = new System.Drawing.Size(12, 13);
			this.labelFateMax.TabIndex = 145;
			this.labelFateMax.Text = "/";
			// 
			// labelFate
			// 
			this.labelFate.AutoSize = true;
			this.labelFate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFate.Location = new System.Drawing.Point(143, 62);
			this.labelFate.Name = "labelFate";
			this.labelFate.Size = new System.Drawing.Size(66, 13);
			this.labelFate.TabIndex = 143;
			this.labelFate.Text = "Fate Points :";
			// 
			// textBoxCorruption
			// 
			this.textBoxCorruption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCorruption.Location = new System.Drawing.Point(80, 117);
			this.textBoxCorruption.MaxLength = 2;
			this.textBoxCorruption.Name = "textBoxCorruption";
			this.textBoxCorruption.Size = new System.Drawing.Size(57, 20);
			this.textBoxCorruption.TabIndex = 142;
			this.textBoxCorruption.Text = "";
			// 
			// labelCorruption
			// 
			this.labelCorruption.AutoSize = true;
			this.labelCorruption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCorruption.Location = new System.Drawing.Point(77, 101);
			this.labelCorruption.Name = "labelCorruption";
			this.labelCorruption.Size = new System.Drawing.Size(61, 13);
			this.labelCorruption.TabIndex = 141;
			this.labelCorruption.Text = "Corruption :";
			// 
			// textBoxInsanity
			// 
			this.textBoxInsanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxInsanity.Location = new System.Drawing.Point(80, 78);
			this.textBoxInsanity.MaxLength = 2;
			this.textBoxInsanity.Name = "textBoxInsanity";
			this.textBoxInsanity.Size = new System.Drawing.Size(57, 20);
			this.textBoxInsanity.TabIndex = 140;
			this.textBoxInsanity.Text = "";
			// 
			// labelInanity
			// 
			this.labelInanity.AutoSize = true;
			this.labelInanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelInanity.Location = new System.Drawing.Point(77, 62);
			this.labelInanity.Name = "labelInanity";
			this.labelInanity.Size = new System.Drawing.Size(49, 13);
			this.labelInanity.TabIndex = 139;
			this.labelInanity.Text = "Insanity :";
			// 
			// labelXpSpent
			// 
			this.labelXpSpent.AutoSize = true;
			this.labelXpSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelXpSpent.Location = new System.Drawing.Point(3, 62);
			this.labelXpSpent.Name = "labelXpSpent";
			this.labelXpSpent.Size = new System.Drawing.Size(56, 13);
			this.labelXpSpent.TabIndex = 107;
			this.labelXpSpent.Text = "Exp Spent";
			// 
			// labelXpLeft
			// 
			this.labelXpLeft.AutoSize = true;
			this.labelXpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelXpLeft.Location = new System.Drawing.Point(3, 101);
			this.labelXpLeft.Name = "labelXpLeft";
			this.labelXpLeft.Size = new System.Drawing.Size(43, 13);
			this.labelXpLeft.TabIndex = 106;
			this.labelXpLeft.Text = "ExpLeft";
			// 
			// labelWounds
			// 
			this.labelWounds.AutoSize = true;
			this.labelWounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWounds.Location = new System.Drawing.Point(143, 101);
			this.labelWounds.Name = "labelWounds";
			this.labelWounds.Size = new System.Drawing.Size(47, 13);
			this.labelWounds.TabIndex = 105;
			this.labelWounds.Text = "Wounds";
			// 
			// buttonSpendXp
			// 
			this.buttonSpendXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSpendXp.Location = new System.Drawing.Point(6, 143);
			this.buttonSpendXp.Name = "buttonSpendXp";
			this.buttonSpendXp.Size = new System.Drawing.Size(68, 23);
			this.buttonSpendXp.TabIndex = 96;
			this.buttonSpendXp.Text = "Spend XP";
			this.buttonSpendXp.UseVisualStyleBackColor = true;
			this.buttonSpendXp.Click += new System.EventHandler(this.buttonSpendXp_Click);
			// 
			// textBoxXpLeft
			// 
			this.textBoxXpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxXpLeft.Location = new System.Drawing.Point(6, 117);
			this.textBoxXpLeft.Name = "textBoxXpLeft";
			this.textBoxXpLeft.ReadOnly = true;
			this.textBoxXpLeft.Size = new System.Drawing.Size(68, 20);
			this.textBoxXpLeft.TabIndex = 95;
			this.textBoxXpLeft.Text = "";
			// 
			// textBoxXpSpent
			// 
			this.textBoxXpSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxXpSpent.Location = new System.Drawing.Point(6, 78);
			this.textBoxXpSpent.Name = "textBoxXpSpent";
			this.textBoxXpSpent.ReadOnly = true;
			this.textBoxXpSpent.Size = new System.Drawing.Size(68, 20);
			this.textBoxXpSpent.TabIndex = 94;
			this.textBoxXpSpent.Text = "";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(6, 38);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(251, 20);
			this.textBoxName.TabIndex = 88;
			this.textBoxName.Text = "";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(3, 22);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 80;
			this.labelName.Text = "Name";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.listBoxTalentDetails);
			this.groupBox5.Controls.Add(this.textBoxTalents);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.Location = new System.Drawing.Point(467, 13);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(507, 209);
			this.groupBox5.TabIndex = 21;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Talents";
			// 
			// listBoxTalentDetails
			// 
			this.listBoxTalentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxTalentDetails.FormattingEnabled = true;
			this.listBoxTalentDetails.Location = new System.Drawing.Point(6, 19);
			this.listBoxTalentDetails.Name = "listBoxTalentDetails";
			this.listBoxTalentDetails.Size = new System.Drawing.Size(234, 56);
			this.listBoxTalentDetails.TabIndex = 68;
			this.listBoxTalentDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxTalantDetails_SelectedIndexChanged);
			// 
			// textBoxTalents
			// 
			this.textBoxTalents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTalents.Location = new System.Drawing.Point(6, 81);
			this.textBoxTalents.Name = "textBoxTalents";
			this.textBoxTalents.ReadOnly = true;
			this.textBoxTalents.Size = new System.Drawing.Size(495, 122);
			this.textBoxTalents.TabIndex = 74;
			this.textBoxTalents.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxSpecialRules);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.Location = new System.Drawing.Point(467, 228);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(507, 189);
			this.groupBox4.TabIndex = 21;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Special Rules";
			// 
			// textBoxSpecialRules
			// 
			this.textBoxSpecialRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSpecialRules.Location = new System.Drawing.Point(6, 19);
			this.textBoxSpecialRules.Name = "textBoxSpecialRules";
			this.textBoxSpecialRules.ReadOnly = true;
			this.textBoxSpecialRules.Size = new System.Drawing.Size(495, 164);
			this.textBoxSpecialRules.TabIndex = 80;
			this.textBoxSpecialRules.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBoxAptitudes);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(277, 228);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 189);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Aptitudes";
			// 
			// textBoxAptitudes
			// 
			this.textBoxAptitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAptitudes.Location = new System.Drawing.Point(6, 19);
			this.textBoxAptitudes.Name = "textBoxAptitudes";
			this.textBoxAptitudes.ReadOnly = true;
			this.textBoxAptitudes.Size = new System.Drawing.Size(172, 163);
			this.textBoxAptitudes.TabIndex = 75;
			this.textBoxAptitudes.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxSkills);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(8, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(263, 225);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Skills";
			// 
			// textBoxSkills
			// 
			this.textBoxSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSkills.Location = new System.Drawing.Point(6, 19);
			this.textBoxSkills.Name = "textBoxSkills";
			this.textBoxSkills.ReadOnly = true;
			this.textBoxSkills.Size = new System.Drawing.Size(251, 199);
			this.textBoxSkills.TabIndex = 75;
			this.textBoxSkills.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxCharacteristics);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(277, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 209);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Characteristics";
			// 
			// textBoxCharacteristics
			// 
			this.textBoxCharacteristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCharacteristics.Location = new System.Drawing.Point(6, 19);
			this.textBoxCharacteristics.Name = "textBoxCharacteristics";
			this.textBoxCharacteristics.ReadOnly = true;
			this.textBoxCharacteristics.Size = new System.Drawing.Size(172, 182);
			this.textBoxCharacteristics.TabIndex = 75;
			this.textBoxCharacteristics.Text = "";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageMain);
			this.tabControl1.Controls.Add(this.tabPageDisplauInLabel);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1084, 468);
			this.tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonChangeDescription);
			this.tabPage1.Controls.Add(this.textBoxRegiment);
			this.tabPage1.Controls.Add(this.textBoxSpecialty);
			this.tabPage1.Controls.Add(this.textBoxDescription);
			this.tabPage1.Controls.Add(this.textBoxDemeanor);
			this.tabPage1.Controls.Add(this.labelRegiment);
			this.tabPage1.Controls.Add(this.labelSpecialty);
			this.tabPage1.Controls.Add(this.labelDemeanour);
			this.tabPage1.Controls.Add(this.labelDescription);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1076, 442);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonChangeDescription
			// 
			this.buttonChangeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChangeDescription.Location = new System.Drawing.Point(8, 298);
			this.buttonChangeDescription.Name = "buttonChangeDescription";
			this.buttonChangeDescription.Size = new System.Drawing.Size(116, 23);
			this.buttonChangeDescription.TabIndex = 103;
			this.buttonChangeDescription.Text = "Change Description";
			this.buttonChangeDescription.UseVisualStyleBackColor = true;
			// 
			// textBoxRegiment
			// 
			this.textBoxRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxRegiment.Location = new System.Drawing.Point(127, 52);
			this.textBoxRegiment.Name = "textBoxRegiment";
			this.textBoxRegiment.ReadOnly = true;
			this.textBoxRegiment.Size = new System.Drawing.Size(132, 20);
			this.textBoxRegiment.TabIndex = 102;
			this.textBoxRegiment.Text = "";
			// 
			// textBoxSpecialty
			// 
			this.textBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSpecialty.Location = new System.Drawing.Point(8, 52);
			this.textBoxSpecialty.Name = "textBoxSpecialty";
			this.textBoxSpecialty.ReadOnly = true;
			this.textBoxSpecialty.Size = new System.Drawing.Size(113, 20);
			this.textBoxSpecialty.TabIndex = 101;
			this.textBoxSpecialty.Text = "";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.Location = new System.Drawing.Point(8, 196);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(251, 96);
			this.textBoxDescription.TabIndex = 98;
			this.textBoxDescription.Text = "";
			// 
			// textBoxDemeanor
			// 
			this.textBoxDemeanor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDemeanor.Location = new System.Drawing.Point(8, 91);
			this.textBoxDemeanor.Name = "textBoxDemeanor";
			this.textBoxDemeanor.ReadOnly = true;
			this.textBoxDemeanor.Size = new System.Drawing.Size(251, 85);
			this.textBoxDemeanor.TabIndex = 99;
			this.textBoxDemeanor.Text = "";
			// 
			// labelRegiment
			// 
			this.labelRegiment.AutoSize = true;
			this.labelRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRegiment.Location = new System.Drawing.Point(124, 36);
			this.labelRegiment.Name = "labelRegiment";
			this.labelRegiment.Size = new System.Drawing.Size(52, 13);
			this.labelRegiment.TabIndex = 94;
			this.labelRegiment.Text = "Regiment";
			// 
			// labelSpecialty
			// 
			this.labelSpecialty.AutoSize = true;
			this.labelSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSpecialty.Location = new System.Drawing.Point(5, 36);
			this.labelSpecialty.Name = "labelSpecialty";
			this.labelSpecialty.Size = new System.Drawing.Size(50, 13);
			this.labelSpecialty.TabIndex = 95;
			this.labelSpecialty.Text = "Specialty";
			// 
			// labelDemeanour
			// 
			this.labelDemeanour.AutoSize = true;
			this.labelDemeanour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDemeanour.Location = new System.Drawing.Point(5, 75);
			this.labelDemeanour.Name = "labelDemeanour";
			this.labelDemeanour.Size = new System.Drawing.Size(56, 13);
			this.labelDemeanour.TabIndex = 96;
			this.labelDemeanour.Text = "Demeanor";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDescription.Location = new System.Drawing.Point(5, 179);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(60, 13);
			this.labelDescription.TabIndex = 97;
			this.labelDescription.Text = "Description";
			// 
			// charGenMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 471);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "charGenMain";
			this.Text = "Character Generator";
			this.Shown += new System.EventHandler(this.charGenMain_Shown);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.tabPageDisplauInLabel.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreateCharacter;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCharacterToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPageDisplauInLabel;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.RichTextBox richTextBoxCurrentlyKnown;
		private System.Windows.Forms.ListBox listBoxTalentDetails;
		private System.Windows.Forms.Button showCharacteristics;
		private System.Windows.Forms.Button showAptitudes;
		private System.Windows.Forms.Button showTalents;
		private System.Windows.Forms.Button showSkills;
		private System.Windows.Forms.RichTextBox textBoxTalents;
		private System.Windows.Forms.Button showCharacter;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RichTextBox textBoxSpecialRules;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button buttonSpendXp;
		private System.Windows.Forms.RichTextBox textBoxXpLeft;
		private System.Windows.Forms.RichTextBox textBoxXpSpent;
		private System.Windows.Forms.RichTextBox textBoxWoundsCurrent;
		private System.Windows.Forms.RichTextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RichTextBox textBoxAptitudes;
		private System.Windows.Forms.RichTextBox textBoxSkills;
		private System.Windows.Forms.RichTextBox textBoxCharacteristics;
		private System.Windows.Forms.ToolStripMenuItem addExpirienceToolStripMenuItem;
		private System.Windows.Forms.Label labelXpSpent;
		private System.Windows.Forms.Label labelXpLeft;
		private System.Windows.Forms.Label labelWounds;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button buttonChangeDescription;
		private System.Windows.Forms.RichTextBox textBoxRegiment;
		private System.Windows.Forms.RichTextBox textBoxSpecialty;
		private System.Windows.Forms.RichTextBox textBoxDescription;
		private System.Windows.Forms.RichTextBox textBoxDemeanor;
		private System.Windows.Forms.Label labelRegiment;
		private System.Windows.Forms.Label labelSpecialty;
		private System.Windows.Forms.Label labelDemeanour;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.RichTextBox textBoxFateCurrent;
		private System.Windows.Forms.Label labelFateMax;
		private System.Windows.Forms.Label labelFate;
		private System.Windows.Forms.RichTextBox textBoxCorruption;
		private System.Windows.Forms.Label labelCorruption;
		private System.Windows.Forms.RichTextBox textBoxInsanity;
		private System.Windows.Forms.Label labelInanity;
		private System.Windows.Forms.Label labelWoundsMax;
	}
}

