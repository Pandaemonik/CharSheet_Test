namespace Char_Generator
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
			this.exportCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemCreateRegiment = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemCreateCharacter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.tabPageDisplauInLabel = new System.Windows.Forms.TabPage();
			this.showCharacter = new System.Windows.Forms.Button();
			this.listBoxCharacters = new System.Windows.Forms.ListBox();
			this.showAttributes = new System.Windows.Forms.Button();
			this.showAptitudes = new System.Windows.Forms.Button();
			this.showTalents = new System.Windows.Forms.Button();
			this.showSkills = new System.Windows.Forms.Button();
			this.richTextBoxCurrentlyKnown = new System.Windows.Forms.RichTextBox();
			this.labelCurrentlyKnown = new System.Windows.Forms.Label();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.buttonChangeDescription = new System.Windows.Forms.Button();
			this.buttonSpendXp = new System.Windows.Forms.Button();
			this.textBoxXpLeft = new System.Windows.Forms.RichTextBox();
			this.textBoxXpSpent = new System.Windows.Forms.RichTextBox();
			this.labelXpSpent = new System.Windows.Forms.Label();
			this.labelXpLeft = new System.Windows.Forms.Label();
			this.textBoxRegiment = new System.Windows.Forms.RichTextBox();
			this.textBoxSpecialty = new System.Windows.Forms.RichTextBox();
			this.textBoxWounds = new System.Windows.Forms.RichTextBox();
			this.textBoxName = new System.Windows.Forms.RichTextBox();
			this.textBoxDescription = new System.Windows.Forms.RichTextBox();
			this.textBoxDemeanor = new System.Windows.Forms.RichTextBox();
			this.labelWounds = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelRegiment = new System.Windows.Forms.Label();
			this.labelSpecialty = new System.Windows.Forms.Label();
			this.labelDemeanour = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
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
			this.textBoxAttributes = new System.Windows.Forms.RichTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
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
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCharacterToolStripMenuItem,
            this.importCharacterToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exportCharacterToolStripMenuItem
			// 
			this.exportCharacterToolStripMenuItem.Name = "exportCharacterToolStripMenuItem";
			this.exportCharacterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exportCharacterToolStripMenuItem.Text = "Export Character";
			this.exportCharacterToolStripMenuItem.Click += new System.EventHandler(this.exportCharacterToolStripMenuItem_Click);
			// 
			// importCharacterToolStripMenuItem
			// 
			this.importCharacterToolStripMenuItem.Name = "importCharacterToolStripMenuItem";
			this.importCharacterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.importCharacterToolStripMenuItem.Text = "Import Character";
			this.importCharacterToolStripMenuItem.Click += new System.EventHandler(this.importCharacterToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// displayToolStripMenuItem
			// 
			this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCreateRegiment,
            this.MenuItemCreateCharacter});
			this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
			this.displayToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.displayToolStripMenuItem.Text = "&Create";
			// 
			// MenuItemCreateRegiment
			// 
			this.MenuItemCreateRegiment.Name = "MenuItemCreateRegiment";
			this.MenuItemCreateRegiment.Size = new System.Drawing.Size(152, 22);
			this.MenuItemCreateRegiment.Text = "Regiment";
			this.MenuItemCreateRegiment.Click += new System.EventHandler(this.MenuItemCreateRegiment_Click);
			// 
			// MenuItemCreateCharacter
			// 
			this.MenuItemCreateCharacter.Name = "MenuItemCreateCharacter";
			this.MenuItemCreateCharacter.Size = new System.Drawing.Size(152, 22);
			this.MenuItemCreateCharacter.Text = "Character";
			this.MenuItemCreateCharacter.Click += new System.EventHandler(this.MenuItemCreateCharacter_Click);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(990, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "MainMenuStrip";
			// 
			// tabPageDisplauInLabel
			// 
			this.tabPageDisplauInLabel.Controls.Add(this.showCharacter);
			this.tabPageDisplauInLabel.Controls.Add(this.listBoxCharacters);
			this.tabPageDisplauInLabel.Controls.Add(this.showAttributes);
			this.tabPageDisplauInLabel.Controls.Add(this.showAptitudes);
			this.tabPageDisplauInLabel.Controls.Add(this.showTalents);
			this.tabPageDisplauInLabel.Controls.Add(this.showSkills);
			this.tabPageDisplauInLabel.Controls.Add(this.richTextBoxCurrentlyKnown);
			this.tabPageDisplauInLabel.Controls.Add(this.labelCurrentlyKnown);
			this.tabPageDisplauInLabel.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisplauInLabel.Name = "tabPageDisplauInLabel";
			this.tabPageDisplauInLabel.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisplauInLabel.Size = new System.Drawing.Size(1076, 442);
			this.tabPageDisplauInLabel.TabIndex = 1;
			this.tabPageDisplauInLabel.Text = "Debug Window";
			this.tabPageDisplauInLabel.UseVisualStyleBackColor = true;
			// 
			// showCharacter
			// 
			this.showCharacter.Location = new System.Drawing.Point(486, 144);
			this.showCharacter.Name = "showCharacter";
			this.showCharacter.Size = new System.Drawing.Size(92, 23);
			this.showCharacter.TabIndex = 74;
			this.showCharacter.Text = "Show Character";
			this.showCharacter.UseVisualStyleBackColor = true;
			this.showCharacter.Click += new System.EventHandler(this.showCharacter_Click);
			// 
			// listBoxCharacters
			// 
			this.listBoxCharacters.FormattingEnabled = true;
			this.listBoxCharacters.Location = new System.Drawing.Point(584, 20);
			this.listBoxCharacters.Name = "listBoxCharacters";
			this.listBoxCharacters.Size = new System.Drawing.Size(244, 30);
			this.listBoxCharacters.TabIndex = 72;
			// 
			// showAttributes
			// 
			this.showAttributes.Location = new System.Drawing.Point(486, 113);
			this.showAttributes.Name = "showAttributes";
			this.showAttributes.Size = new System.Drawing.Size(92, 25);
			this.showAttributes.TabIndex = 61;
			this.showAttributes.Text = "Show Attributes";
			this.showAttributes.UseVisualStyleBackColor = true;
			this.showAttributes.Click += new System.EventHandler(this.showAttributes_Click);
			// 
			// showAptitudes
			// 
			this.showAptitudes.Location = new System.Drawing.Point(486, 82);
			this.showAptitudes.Name = "showAptitudes";
			this.showAptitudes.Size = new System.Drawing.Size(92, 25);
			this.showAptitudes.TabIndex = 60;
			this.showAptitudes.Text = "Show Aptitudes";
			this.showAptitudes.UseVisualStyleBackColor = true;
			this.showAptitudes.Click += new System.EventHandler(this.showAptitudes_Click);
			// 
			// showTalents
			// 
			this.showTalents.Location = new System.Drawing.Point(486, 51);
			this.showTalents.Name = "showTalents";
			this.showTalents.Size = new System.Drawing.Size(92, 25);
			this.showTalents.TabIndex = 59;
			this.showTalents.Text = "Show Talents";
			this.showTalents.UseVisualStyleBackColor = true;
			this.showTalents.Click += new System.EventHandler(this.showTalents_Click);
			// 
			// showSkills
			// 
			this.showSkills.Location = new System.Drawing.Point(486, 20);
			this.showSkills.Name = "showSkills";
			this.showSkills.Size = new System.Drawing.Size(92, 25);
			this.showSkills.TabIndex = 58;
			this.showSkills.Text = "Show Skills";
			this.showSkills.UseVisualStyleBackColor = true;
			this.showSkills.Click += new System.EventHandler(this.showSkills_Click);
			// 
			// richTextBoxCurrentlyKnown
			// 
			this.richTextBoxCurrentlyKnown.Location = new System.Drawing.Point(8, 20);
			this.richTextBoxCurrentlyKnown.Name = "richTextBoxCurrentlyKnown";
			this.richTextBoxCurrentlyKnown.ReadOnly = true;
			this.richTextBoxCurrentlyKnown.Size = new System.Drawing.Size(472, 397);
			this.richTextBoxCurrentlyKnown.TabIndex = 57;
			this.richTextBoxCurrentlyKnown.Text = "";
			// 
			// labelCurrentlyKnown
			// 
			this.labelCurrentlyKnown.AutoSize = true;
			this.labelCurrentlyKnown.Location = new System.Drawing.Point(5, 3);
			this.labelCurrentlyKnown.Name = "labelCurrentlyKnown";
			this.labelCurrentlyKnown.Size = new System.Drawing.Size(83, 13);
			this.labelCurrentlyKnown.TabIndex = 56;
			this.labelCurrentlyKnown.Text = "Currently known";
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
			this.groupBox6.Controls.Add(this.buttonChangeDescription);
			this.groupBox6.Controls.Add(this.buttonSpendXp);
			this.groupBox6.Controls.Add(this.textBoxXpLeft);
			this.groupBox6.Controls.Add(this.textBoxXpSpent);
			this.groupBox6.Controls.Add(this.labelXpSpent);
			this.groupBox6.Controls.Add(this.labelXpLeft);
			this.groupBox6.Controls.Add(this.textBoxRegiment);
			this.groupBox6.Controls.Add(this.textBoxSpecialty);
			this.groupBox6.Controls.Add(this.textBoxWounds);
			this.groupBox6.Controls.Add(this.textBoxName);
			this.groupBox6.Controls.Add(this.textBoxDescription);
			this.groupBox6.Controls.Add(this.textBoxDemeanor);
			this.groupBox6.Controls.Add(this.labelWounds);
			this.groupBox6.Controls.Add(this.labelName);
			this.groupBox6.Controls.Add(this.labelRegiment);
			this.groupBox6.Controls.Add(this.labelSpecialty);
			this.groupBox6.Controls.Add(this.labelDemeanour);
			this.groupBox6.Controls.Add(this.labelDescription);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox6.Location = new System.Drawing.Point(8, 13);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(263, 404);
			this.groupBox6.TabIndex = 80;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Bio && Info";
			// 
			// buttonChangeDescription
			// 
			this.buttonChangeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChangeDescription.Location = new System.Drawing.Point(6, 362);
			this.buttonChangeDescription.Name = "buttonChangeDescription";
			this.buttonChangeDescription.Size = new System.Drawing.Size(116, 23);
			this.buttonChangeDescription.TabIndex = 97;
			this.buttonChangeDescription.Text = "Change Description";
			this.buttonChangeDescription.UseVisualStyleBackColor = true;
			// 
			// buttonSpendXp
			// 
			this.buttonSpendXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSpendXp.Location = new System.Drawing.Point(136, 362);
			this.buttonSpendXp.Name = "buttonSpendXp";
			this.buttonSpendXp.Size = new System.Drawing.Size(75, 23);
			this.buttonSpendXp.TabIndex = 96;
			this.buttonSpendXp.Text = "Spend XP";
			this.buttonSpendXp.UseVisualStyleBackColor = true;
			this.buttonSpendXp.Click += new System.EventHandler(this.buttonSpendXp_Click);
			// 
			// textBoxXpLeft
			// 
			this.textBoxXpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxXpLeft.Location = new System.Drawing.Point(136, 336);
			this.textBoxXpLeft.Name = "textBoxXpLeft";
			this.textBoxXpLeft.ReadOnly = true;
			this.textBoxXpLeft.Size = new System.Drawing.Size(57, 20);
			this.textBoxXpLeft.TabIndex = 95;
			this.textBoxXpLeft.Text = "";
			// 
			// textBoxXpSpent
			// 
			this.textBoxXpSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxXpSpent.Location = new System.Drawing.Point(65, 336);
			this.textBoxXpSpent.Name = "textBoxXpSpent";
			this.textBoxXpSpent.ReadOnly = true;
			this.textBoxXpSpent.Size = new System.Drawing.Size(57, 20);
			this.textBoxXpSpent.TabIndex = 94;
			this.textBoxXpSpent.Text = "";
			// 
			// labelXpSpent
			// 
			this.labelXpSpent.AutoSize = true;
			this.labelXpSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelXpSpent.Location = new System.Drawing.Point(62, 320);
			this.labelXpSpent.Name = "labelXpSpent";
			this.labelXpSpent.Size = new System.Drawing.Size(56, 13);
			this.labelXpSpent.TabIndex = 93;
			this.labelXpSpent.Text = "Exp Spent";
			// 
			// labelXpLeft
			// 
			this.labelXpLeft.AutoSize = true;
			this.labelXpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelXpLeft.Location = new System.Drawing.Point(133, 320);
			this.labelXpLeft.Name = "labelXpLeft";
			this.labelXpLeft.Size = new System.Drawing.Size(43, 13);
			this.labelXpLeft.TabIndex = 92;
			this.labelXpLeft.Text = "ExpLeft";
			// 
			// textBoxRegiment
			// 
			this.textBoxRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxRegiment.Location = new System.Drawing.Point(125, 77);
			this.textBoxRegiment.Name = "textBoxRegiment";
			this.textBoxRegiment.ReadOnly = true;
			this.textBoxRegiment.Size = new System.Drawing.Size(132, 20);
			this.textBoxRegiment.TabIndex = 91;
			this.textBoxRegiment.Text = "";
			// 
			// textBoxSpecialty
			// 
			this.textBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSpecialty.Location = new System.Drawing.Point(6, 77);
			this.textBoxSpecialty.Name = "textBoxSpecialty";
			this.textBoxSpecialty.ReadOnly = true;
			this.textBoxSpecialty.Size = new System.Drawing.Size(113, 20);
			this.textBoxSpecialty.TabIndex = 90;
			this.textBoxSpecialty.Text = "";
			// 
			// textBoxWounds
			// 
			this.textBoxWounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxWounds.Location = new System.Drawing.Point(6, 336);
			this.textBoxWounds.Name = "textBoxWounds";
			this.textBoxWounds.ReadOnly = true;
			this.textBoxWounds.Size = new System.Drawing.Size(44, 20);
			this.textBoxWounds.TabIndex = 89;
			this.textBoxWounds.Text = "";
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
			// textBoxDescription
			// 
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.Location = new System.Drawing.Point(6, 221);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(251, 96);
			this.textBoxDescription.TabIndex = 85;
			this.textBoxDescription.Text = "";
			// 
			// textBoxDemeanor
			// 
			this.textBoxDemeanor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDemeanor.Location = new System.Drawing.Point(6, 116);
			this.textBoxDemeanor.Name = "textBoxDemeanor";
			this.textBoxDemeanor.ReadOnly = true;
			this.textBoxDemeanor.Size = new System.Drawing.Size(251, 85);
			this.textBoxDemeanor.TabIndex = 86;
			this.textBoxDemeanor.Text = "";
			// 
			// labelWounds
			// 
			this.labelWounds.AutoSize = true;
			this.labelWounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWounds.Location = new System.Drawing.Point(3, 320);
			this.labelWounds.Name = "labelWounds";
			this.labelWounds.Size = new System.Drawing.Size(47, 13);
			this.labelWounds.TabIndex = 87;
			this.labelWounds.Text = "Wounds";
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
			// labelRegiment
			// 
			this.labelRegiment.AutoSize = true;
			this.labelRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRegiment.Location = new System.Drawing.Point(122, 61);
			this.labelRegiment.Name = "labelRegiment";
			this.labelRegiment.Size = new System.Drawing.Size(52, 13);
			this.labelRegiment.TabIndex = 81;
			this.labelRegiment.Text = "Regiment";
			// 
			// labelSpecialty
			// 
			this.labelSpecialty.AutoSize = true;
			this.labelSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSpecialty.Location = new System.Drawing.Point(3, 61);
			this.labelSpecialty.Name = "labelSpecialty";
			this.labelSpecialty.Size = new System.Drawing.Size(50, 13);
			this.labelSpecialty.TabIndex = 82;
			this.labelSpecialty.Text = "Specialty";
			// 
			// labelDemeanour
			// 
			this.labelDemeanour.AutoSize = true;
			this.labelDemeanour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDemeanour.Location = new System.Drawing.Point(3, 100);
			this.labelDemeanour.Name = "labelDemeanour";
			this.labelDemeanour.Size = new System.Drawing.Size(56, 13);
			this.labelDemeanour.TabIndex = 83;
			this.labelDemeanour.Text = "Demeanor";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDescription.Location = new System.Drawing.Point(3, 204);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(60, 13);
			this.labelDescription.TabIndex = 84;
			this.labelDescription.Text = "Description";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.listBoxTalentDetails);
			this.groupBox5.Controls.Add(this.textBoxTalents);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.Location = new System.Drawing.Point(728, 13);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(246, 209);
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
			this.textBoxTalents.Size = new System.Drawing.Size(234, 122);
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
			this.groupBox2.Location = new System.Drawing.Point(467, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(255, 209);
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
			this.textBoxSkills.Size = new System.Drawing.Size(243, 182);
			this.textBoxSkills.TabIndex = 75;
			this.textBoxSkills.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAttributes);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(277, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 209);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Attributes";
			// 
			// textBoxAttributes
			// 
			this.textBoxAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAttributes.Location = new System.Drawing.Point(6, 19);
			this.textBoxAttributes.Name = "textBoxAttributes";
			this.textBoxAttributes.ReadOnly = true;
			this.textBoxAttributes.Size = new System.Drawing.Size(172, 182);
			this.textBoxAttributes.TabIndex = 75;
			this.textBoxAttributes.Text = "";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageMain);
			this.tabControl1.Controls.Add(this.tabPageDisplauInLabel);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1084, 468);
			this.tabControl1.TabIndex = 15;
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
			this.tabPageDisplauInLabel.PerformLayout();
			this.tabPageMain.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreateRegiment;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreateCharacter;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem exportCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCharacterToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPageDisplauInLabel;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.RichTextBox richTextBoxCurrentlyKnown;
		private System.Windows.Forms.Label labelCurrentlyKnown;
		private System.Windows.Forms.ListBox listBoxTalentDetails;
		private System.Windows.Forms.ListBox listBoxCharacters;
		private System.Windows.Forms.Button showAttributes;
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
		private System.Windows.Forms.Label labelXpSpent;
		private System.Windows.Forms.Label labelXpLeft;
		private System.Windows.Forms.RichTextBox textBoxRegiment;
		private System.Windows.Forms.RichTextBox textBoxSpecialty;
		private System.Windows.Forms.RichTextBox textBoxWounds;
		private System.Windows.Forms.RichTextBox textBoxName;
		private System.Windows.Forms.RichTextBox textBoxDescription;
		private System.Windows.Forms.RichTextBox textBoxDemeanor;
		private System.Windows.Forms.Label labelWounds;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelRegiment;
		private System.Windows.Forms.Label labelSpecialty;
		private System.Windows.Forms.Label labelDemeanour;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button buttonChangeDescription;
		private System.Windows.Forms.RichTextBox textBoxAptitudes;
		private System.Windows.Forms.RichTextBox textBoxSkills;
		private System.Windows.Forms.RichTextBox textBoxAttributes;
	}
}

