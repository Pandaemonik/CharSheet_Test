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
			this.loadTalantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveTalantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayInDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayInLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.tabPageDisplauInLabel = new System.Windows.Forms.TabPage();
			this.richTextBoxCurrentlyKnown = new System.Windows.Forms.RichTextBox();
			this.labelCurrentlyKnown = new System.Windows.Forms.Label();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.buttonSaveCharacterJson = new System.Windows.Forms.Button();
			this.listBoxCharacters = new System.Windows.Forms.ListBox();
			this.buttonSaveAsJson = new System.Windows.Forms.Button();
			this.buttonSaveAsXml = new System.Windows.Forms.Button();
			this.listBoxTalantDetails = new System.Windows.Forms.ListBox();
			this.richTextBoxPrerequisites = new System.Windows.Forms.RichTextBox();
			this.richTextBoxAptitudes = new System.Windows.Forms.RichTextBox();
			this.richTextBoxTier = new System.Windows.Forms.RichTextBox();
			this.richTextBoxName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
			this.richTextBoxBenefit = new System.Windows.Forms.RichTextBox();
			this.labelTier = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPrerequisites = new System.Windows.Forms.Label();
			this.labelAptitudes = new System.Windows.Forms.Label();
			this.labelBenefit = new System.Windows.Forms.Label();
			this.labelDetails = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBoxStrenght = new System.Windows.Forms.RichTextBox();
			this.richTextBoxWillpower = new System.Windows.Forms.RichTextBox();
			this.richTextBoxFellowship = new System.Windows.Forms.RichTextBox();
			this.richTextBoxIntelligence = new System.Windows.Forms.RichTextBox();
			this.richTextBoxAgility = new System.Windows.Forms.RichTextBox();
			this.richTextBoxToughness = new System.Windows.Forms.RichTextBox();
			this.richTextBoxPerception = new System.Windows.Forms.RichTextBox();
			this.richTextBoxBallisticSkill = new System.Windows.Forms.RichTextBox();
			this.labelFellowship = new System.Windows.Forms.Label();
			this.labelWillpower = new System.Windows.Forms.Label();
			this.labelPerception = new System.Windows.Forms.Label();
			this.labelIntelligence = new System.Windows.Forms.Label();
			this.labelAgility = new System.Windows.Forms.Label();
			this.labelToughness = new System.Windows.Forms.Label();
			this.labelStrength = new System.Windows.Forms.Label();
			this.labelWeaponSkill = new System.Windows.Forms.Label();
			this.labelBallisticSkill = new System.Windows.Forms.Label();
			this.richTextBoxWeaponSkill = new System.Windows.Forms.RichTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.menuStripMain.SuspendLayout();
			this.tabPageDisplauInLabel.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTalantsToolStripMenuItem,
            this.saveTalantsToolStripMenuItem,
            this.loadCharacterToolStripMenuItem,
            this.saveCharacterToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// loadTalantsToolStripMenuItem
			// 
			this.loadTalantsToolStripMenuItem.Name = "loadTalantsToolStripMenuItem";
			this.loadTalantsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.loadTalantsToolStripMenuItem.Text = "Load Talent";
			this.loadTalantsToolStripMenuItem.Click += new System.EventHandler(this.loadTalantsToolStripMenuItem_Click);
			// 
			// saveTalantsToolStripMenuItem
			// 
			this.saveTalantsToolStripMenuItem.Name = "saveTalantsToolStripMenuItem";
			this.saveTalantsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.saveTalantsToolStripMenuItem.Text = "Save Talent";
			this.saveTalantsToolStripMenuItem.Click += new System.EventHandler(this.saveTalantsToolStripMenuItem_Click);
			// 
			// loadCharacterToolStripMenuItem
			// 
			this.loadCharacterToolStripMenuItem.Enabled = false;
			this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
			this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.loadCharacterToolStripMenuItem.Text = "Load Character";
			// 
			// saveCharacterToolStripMenuItem
			// 
			this.saveCharacterToolStripMenuItem.Enabled = false;
			this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
			this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.saveCharacterToolStripMenuItem.Text = "Save Character";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// displayToolStripMenuItem
			// 
			this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayInDetailsToolStripMenuItem,
            this.displayInLabelToolStripMenuItem});
			this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
			this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.displayToolStripMenuItem.Text = "&Display";
			// 
			// displayInDetailsToolStripMenuItem
			// 
			this.displayInDetailsToolStripMenuItem.Enabled = false;
			this.displayInDetailsToolStripMenuItem.Name = "displayInDetailsToolStripMenuItem";
			this.displayInDetailsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.displayInDetailsToolStripMenuItem.Text = "Display in details";
			this.displayInDetailsToolStripMenuItem.Click += new System.EventHandler(this.displayInDetailsToolStripMenuItem_Click);
			// 
			// displayInLabelToolStripMenuItem
			// 
			this.displayInLabelToolStripMenuItem.Enabled = false;
			this.displayInLabelToolStripMenuItem.Name = "displayInLabelToolStripMenuItem";
			this.displayInLabelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.displayInLabelToolStripMenuItem.Text = "Display in Known";
			this.displayInLabelToolStripMenuItem.Click += new System.EventHandler(this.displayInLabelToolStripMenuItem_Click);
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
			this.tabPageDisplauInLabel.Controls.Add(this.richTextBoxCurrentlyKnown);
			this.tabPageDisplauInLabel.Controls.Add(this.labelCurrentlyKnown);
			this.tabPageDisplauInLabel.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisplauInLabel.Name = "tabPageDisplauInLabel";
			this.tabPageDisplauInLabel.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisplauInLabel.Size = new System.Drawing.Size(1076, 426);
			this.tabPageDisplauInLabel.TabIndex = 1;
			this.tabPageDisplauInLabel.Text = "Debug Window";
			this.tabPageDisplauInLabel.UseVisualStyleBackColor = true;
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
			this.tabPageMain.Controls.Add(this.buttonSaveCharacterJson);
			this.tabPageMain.Controls.Add(this.listBoxCharacters);
			this.tabPageMain.Controls.Add(this.buttonSaveAsJson);
			this.tabPageMain.Controls.Add(this.buttonSaveAsXml);
			this.tabPageMain.Controls.Add(this.listBoxTalantDetails);
			this.tabPageMain.Controls.Add(this.richTextBoxPrerequisites);
			this.tabPageMain.Controls.Add(this.richTextBoxAptitudes);
			this.tabPageMain.Controls.Add(this.richTextBoxTier);
			this.tabPageMain.Controls.Add(this.richTextBoxName);
			this.tabPageMain.Controls.Add(this.richTextBoxDetails);
			this.tabPageMain.Controls.Add(this.richTextBoxBenefit);
			this.tabPageMain.Controls.Add(this.labelTier);
			this.tabPageMain.Controls.Add(this.labelName);
			this.tabPageMain.Controls.Add(this.labelPrerequisites);
			this.tabPageMain.Controls.Add(this.labelAptitudes);
			this.tabPageMain.Controls.Add(this.labelBenefit);
			this.tabPageMain.Controls.Add(this.labelDetails);
			this.tabPageMain.Controls.Add(this.groupBox2);
			this.tabPageMain.Controls.Add(this.groupBox1);
			this.tabPageMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(1076, 426);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "MainTab";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// buttonSaveCharacterJson
			// 
			this.buttonSaveCharacterJson.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonSaveCharacterJson.Location = new System.Drawing.Point(730, 358);
			this.buttonSaveCharacterJson.Name = "buttonSaveCharacterJson";
			this.buttonSaveCharacterJson.Size = new System.Drawing.Size(126, 23);
			this.buttonSaveCharacterJson.TabIndex = 72;
			this.buttonSaveCharacterJson.Text = "Save Character JSON";
			this.buttonSaveCharacterJson.UseVisualStyleBackColor = true;
			this.buttonSaveCharacterJson.Click += new System.EventHandler(this.buttonSaveCharacterJson_Click);
			// 
			// listBoxCharacters
			// 
			this.listBoxCharacters.FormattingEnabled = true;
			this.listBoxCharacters.Location = new System.Drawing.Point(730, 26);
			this.listBoxCharacters.Name = "listBoxCharacters";
			this.listBoxCharacters.Size = new System.Drawing.Size(244, 30);
			this.listBoxCharacters.TabIndex = 71;
			this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacters_SelectedIndexChanged);
			// 
			// buttonSaveAsJson
			// 
			this.buttonSaveAsJson.Location = new System.Drawing.Point(560, 387);
			this.buttonSaveAsJson.Name = "buttonSaveAsJson";
			this.buttonSaveAsJson.Size = new System.Drawing.Size(90, 23);
			this.buttonSaveAsJson.TabIndex = 70;
			this.buttonSaveAsJson.Text = "Save as JSON";
			this.buttonSaveAsJson.UseVisualStyleBackColor = true;
			this.buttonSaveAsJson.Click += new System.EventHandler(this.buttonSaveAsJson_Click);
			// 
			// buttonSaveAsXml
			// 
			this.buttonSaveAsXml.Location = new System.Drawing.Point(464, 387);
			this.buttonSaveAsXml.Name = "buttonSaveAsXml";
			this.buttonSaveAsXml.Size = new System.Drawing.Size(90, 23);
			this.buttonSaveAsXml.TabIndex = 69;
			this.buttonSaveAsXml.Text = "Save as XML";
			this.buttonSaveAsXml.UseVisualStyleBackColor = true;
			this.buttonSaveAsXml.Click += new System.EventHandler(this.buttonSaveAsXml_Click);
			// 
			// listBoxTalantDetails
			// 
			this.listBoxTalantDetails.FormattingEnabled = true;
			this.listBoxTalantDetails.Location = new System.Drawing.Point(464, 286);
			this.listBoxTalantDetails.Name = "listBoxTalantDetails";
			this.listBoxTalantDetails.Size = new System.Drawing.Size(260, 95);
			this.listBoxTalantDetails.TabIndex = 68;
			this.listBoxTalantDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxTalantDetails_SelectedIndexChanged);
			// 
			// richTextBoxPrerequisites
			// 
			this.richTextBoxPrerequisites.Location = new System.Drawing.Point(464, 104);
			this.richTextBoxPrerequisites.Name = "richTextBoxPrerequisites";
			this.richTextBoxPrerequisites.ReadOnly = true;
			this.richTextBoxPrerequisites.Size = new System.Drawing.Size(260, 20);
			this.richTextBoxPrerequisites.TabIndex = 67;
			this.richTextBoxPrerequisites.Text = "";
			// 
			// richTextBoxAptitudes
			// 
			this.richTextBoxAptitudes.Location = new System.Drawing.Point(464, 65);
			this.richTextBoxAptitudes.Name = "richTextBoxAptitudes";
			this.richTextBoxAptitudes.ReadOnly = true;
			this.richTextBoxAptitudes.Size = new System.Drawing.Size(260, 20);
			this.richTextBoxAptitudes.TabIndex = 66;
			this.richTextBoxAptitudes.Text = "";
			// 
			// richTextBoxTier
			// 
			this.richTextBoxTier.Location = new System.Drawing.Point(696, 26);
			this.richTextBoxTier.Name = "richTextBoxTier";
			this.richTextBoxTier.ReadOnly = true;
			this.richTextBoxTier.Size = new System.Drawing.Size(28, 20);
			this.richTextBoxTier.TabIndex = 65;
			this.richTextBoxTier.Text = "";
			// 
			// richTextBoxName
			// 
			this.richTextBoxName.Location = new System.Drawing.Point(464, 26);
			this.richTextBoxName.Name = "richTextBoxName";
			this.richTextBoxName.ReadOnly = true;
			this.richTextBoxName.Size = new System.Drawing.Size(226, 20);
			this.richTextBoxName.TabIndex = 64;
			this.richTextBoxName.Text = "";
			// 
			// richTextBoxDetails
			// 
			this.richTextBoxDetails.Location = new System.Drawing.Point(464, 184);
			this.richTextBoxDetails.Name = "richTextBoxDetails";
			this.richTextBoxDetails.ReadOnly = true;
			this.richTextBoxDetails.Size = new System.Drawing.Size(260, 96);
			this.richTextBoxDetails.TabIndex = 61;
			this.richTextBoxDetails.Text = "";
			// 
			// richTextBoxBenefit
			// 
			this.richTextBoxBenefit.Location = new System.Drawing.Point(464, 143);
			this.richTextBoxBenefit.Name = "richTextBoxBenefit";
			this.richTextBoxBenefit.ReadOnly = true;
			this.richTextBoxBenefit.Size = new System.Drawing.Size(260, 22);
			this.richTextBoxBenefit.TabIndex = 62;
			this.richTextBoxBenefit.Text = "";
			// 
			// labelTier
			// 
			this.labelTier.AutoSize = true;
			this.labelTier.Location = new System.Drawing.Point(693, 10);
			this.labelTier.Name = "labelTier";
			this.labelTier.Size = new System.Drawing.Size(25, 13);
			this.labelTier.TabIndex = 63;
			this.labelTier.Text = "Tier";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(461, 10);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 56;
			this.labelName.Text = "Name";
			// 
			// labelPrerequisites
			// 
			this.labelPrerequisites.AutoSize = true;
			this.labelPrerequisites.Location = new System.Drawing.Point(461, 88);
			this.labelPrerequisites.Name = "labelPrerequisites";
			this.labelPrerequisites.Size = new System.Drawing.Size(67, 13);
			this.labelPrerequisites.TabIndex = 57;
			this.labelPrerequisites.Text = "Prerequisites";
			// 
			// labelAptitudes
			// 
			this.labelAptitudes.AutoSize = true;
			this.labelAptitudes.Location = new System.Drawing.Point(461, 49);
			this.labelAptitudes.Name = "labelAptitudes";
			this.labelAptitudes.Size = new System.Drawing.Size(51, 13);
			this.labelAptitudes.TabIndex = 58;
			this.labelAptitudes.Text = "Aptitudes";
			// 
			// labelBenefit
			// 
			this.labelBenefit.AutoSize = true;
			this.labelBenefit.Location = new System.Drawing.Point(461, 127);
			this.labelBenefit.Name = "labelBenefit";
			this.labelBenefit.Size = new System.Drawing.Size(40, 13);
			this.labelBenefit.TabIndex = 59;
			this.labelBenefit.Text = "Benefit";
			// 
			// labelDetails
			// 
			this.labelDetails.AutoSize = true;
			this.labelDetails.Location = new System.Drawing.Point(461, 168);
			this.labelDetails.Name = "labelDetails";
			this.labelDetails.Size = new System.Drawing.Size(39, 13);
			this.labelDetails.TabIndex = 60;
			this.labelDetails.Text = "Details";
			// 
			// groupBox2
			// 
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(203, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(255, 404);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Skills";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBoxStrenght);
			this.groupBox1.Controls.Add(this.richTextBoxWillpower);
			this.groupBox1.Controls.Add(this.richTextBoxFellowship);
			this.groupBox1.Controls.Add(this.richTextBoxIntelligence);
			this.groupBox1.Controls.Add(this.richTextBoxAgility);
			this.groupBox1.Controls.Add(this.richTextBoxToughness);
			this.groupBox1.Controls.Add(this.richTextBoxPerception);
			this.groupBox1.Controls.Add(this.richTextBoxBallisticSkill);
			this.groupBox1.Controls.Add(this.labelFellowship);
			this.groupBox1.Controls.Add(this.labelWillpower);
			this.groupBox1.Controls.Add(this.labelPerception);
			this.groupBox1.Controls.Add(this.labelIntelligence);
			this.groupBox1.Controls.Add(this.labelAgility);
			this.groupBox1.Controls.Add(this.labelToughness);
			this.groupBox1.Controls.Add(this.labelStrength);
			this.groupBox1.Controls.Add(this.labelWeaponSkill);
			this.groupBox1.Controls.Add(this.labelBallisticSkill);
			this.groupBox1.Controls.Add(this.richTextBoxWeaponSkill);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(13, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 404);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Characteristics";
			// 
			// richTextBoxStrenght
			// 
			this.richTextBoxStrenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxStrenght.Location = new System.Drawing.Point(15, 194);
			this.richTextBoxStrenght.Name = "richTextBoxStrenght";
			this.richTextBoxStrenght.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxStrenght.TabIndex = 18;
			this.richTextBoxStrenght.Text = "";
			// 
			// richTextBoxWillpower
			// 
			this.richTextBoxWillpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxWillpower.Location = new System.Drawing.Point(97, 194);
			this.richTextBoxWillpower.Name = "richTextBoxWillpower";
			this.richTextBoxWillpower.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxWillpower.TabIndex = 17;
			this.richTextBoxWillpower.Text = "";
			// 
			// richTextBoxFellowship
			// 
			this.richTextBoxFellowship.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxFellowship.Location = new System.Drawing.Point(97, 269);
			this.richTextBoxFellowship.Name = "richTextBoxFellowship";
			this.richTextBoxFellowship.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxFellowship.TabIndex = 16;
			this.richTextBoxFellowship.Text = "";
			// 
			// richTextBoxIntelligence
			// 
			this.richTextBoxIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxIntelligence.Location = new System.Drawing.Point(97, 44);
			this.richTextBoxIntelligence.Name = "richTextBoxIntelligence";
			this.richTextBoxIntelligence.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxIntelligence.TabIndex = 14;
			this.richTextBoxIntelligence.Text = "";
			// 
			// richTextBoxAgility
			// 
			this.richTextBoxAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxAgility.Location = new System.Drawing.Point(15, 342);
			this.richTextBoxAgility.Name = "richTextBoxAgility";
			this.richTextBoxAgility.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxAgility.TabIndex = 13;
			this.richTextBoxAgility.Text = "";
			// 
			// richTextBoxToughness
			// 
			this.richTextBoxToughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxToughness.Location = new System.Drawing.Point(15, 269);
			this.richTextBoxToughness.Name = "richTextBoxToughness";
			this.richTextBoxToughness.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxToughness.TabIndex = 12;
			this.richTextBoxToughness.Text = "";
			// 
			// richTextBoxPerception
			// 
			this.richTextBoxPerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxPerception.Location = new System.Drawing.Point(97, 119);
			this.richTextBoxPerception.Name = "richTextBoxPerception";
			this.richTextBoxPerception.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxPerception.TabIndex = 11;
			this.richTextBoxPerception.Text = "";
			// 
			// richTextBoxBallisticSkill
			// 
			this.richTextBoxBallisticSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxBallisticSkill.Location = new System.Drawing.Point(15, 119);
			this.richTextBoxBallisticSkill.Name = "richTextBoxBallisticSkill";
			this.richTextBoxBallisticSkill.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxBallisticSkill.TabIndex = 10;
			this.richTextBoxBallisticSkill.Text = "";
			// 
			// labelFellowship
			// 
			this.labelFellowship.AutoSize = true;
			this.labelFellowship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFellowship.Location = new System.Drawing.Point(94, 253);
			this.labelFellowship.Name = "labelFellowship";
			this.labelFellowship.Size = new System.Drawing.Size(56, 13);
			this.labelFellowship.TabIndex = 9;
			this.labelFellowship.Text = "Fellowship";
			// 
			// labelWillpower
			// 
			this.labelWillpower.AutoSize = true;
			this.labelWillpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWillpower.Location = new System.Drawing.Point(94, 178);
			this.labelWillpower.Name = "labelWillpower";
			this.labelWillpower.Size = new System.Drawing.Size(53, 13);
			this.labelWillpower.TabIndex = 8;
			this.labelWillpower.Text = "Willpower";
			// 
			// labelPerception
			// 
			this.labelPerception.AutoSize = true;
			this.labelPerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPerception.Location = new System.Drawing.Point(94, 103);
			this.labelPerception.Name = "labelPerception";
			this.labelPerception.Size = new System.Drawing.Size(58, 13);
			this.labelPerception.TabIndex = 7;
			this.labelPerception.Text = "Perception";
			// 
			// labelIntelligence
			// 
			this.labelIntelligence.AutoSize = true;
			this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntelligence.Location = new System.Drawing.Point(94, 28);
			this.labelIntelligence.Name = "labelIntelligence";
			this.labelIntelligence.Size = new System.Drawing.Size(61, 13);
			this.labelIntelligence.TabIndex = 6;
			this.labelIntelligence.Text = "Intelligence";
			// 
			// labelAgility
			// 
			this.labelAgility.AutoSize = true;
			this.labelAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAgility.Location = new System.Drawing.Point(13, 326);
			this.labelAgility.Name = "labelAgility";
			this.labelAgility.Size = new System.Drawing.Size(34, 13);
			this.labelAgility.TabIndex = 5;
			this.labelAgility.Text = "Agility";
			// 
			// labelToughness
			// 
			this.labelToughness.AutoSize = true;
			this.labelToughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelToughness.Location = new System.Drawing.Point(12, 253);
			this.labelToughness.Name = "labelToughness";
			this.labelToughness.Size = new System.Drawing.Size(60, 13);
			this.labelToughness.TabIndex = 4;
			this.labelToughness.Text = "Toughness";
			// 
			// labelStrength
			// 
			this.labelStrength.AutoSize = true;
			this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStrength.Location = new System.Drawing.Point(12, 178);
			this.labelStrength.Name = "labelStrength";
			this.labelStrength.Size = new System.Drawing.Size(47, 13);
			this.labelStrength.TabIndex = 3;
			this.labelStrength.Text = "Strength";
			// 
			// labelWeaponSkill
			// 
			this.labelWeaponSkill.AutoSize = true;
			this.labelWeaponSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWeaponSkill.Location = new System.Drawing.Point(12, 28);
			this.labelWeaponSkill.Name = "labelWeaponSkill";
			this.labelWeaponSkill.Size = new System.Drawing.Size(70, 13);
			this.labelWeaponSkill.TabIndex = 2;
			this.labelWeaponSkill.Text = "Weapon Skill";
			// 
			// labelBallisticSkill
			// 
			this.labelBallisticSkill.AutoSize = true;
			this.labelBallisticSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBallisticSkill.Location = new System.Drawing.Point(12, 103);
			this.labelBallisticSkill.Name = "labelBallisticSkill";
			this.labelBallisticSkill.Size = new System.Drawing.Size(64, 13);
			this.labelBallisticSkill.TabIndex = 1;
			this.labelBallisticSkill.Text = "Ballistic Skill";
			// 
			// richTextBoxWeaponSkill
			// 
			this.richTextBoxWeaponSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxWeaponSkill.Location = new System.Drawing.Point(15, 44);
			this.richTextBoxWeaponSkill.Name = "richTextBoxWeaponSkill";
			this.richTextBoxWeaponSkill.Size = new System.Drawing.Size(67, 56);
			this.richTextBoxWeaponSkill.TabIndex = 0;
			this.richTextBoxWeaponSkill.Text = "";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageMain);
			this.tabControl1.Controls.Add(this.tabPageDisplauInLabel);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1084, 452);
			this.tabControl1.TabIndex = 15;
			// 
			// charGenMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 478);
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
			this.tabPageMain.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayInDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayInLabelToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem loadTalantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTalantsToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPageDisplauInLabel;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBoxStrenght;
		private System.Windows.Forms.RichTextBox richTextBoxWillpower;
		private System.Windows.Forms.RichTextBox richTextBoxFellowship;
		private System.Windows.Forms.RichTextBox richTextBoxIntelligence;
		private System.Windows.Forms.RichTextBox richTextBoxAgility;
		private System.Windows.Forms.RichTextBox richTextBoxToughness;
		private System.Windows.Forms.RichTextBox richTextBoxPerception;
		private System.Windows.Forms.RichTextBox richTextBoxBallisticSkill;
		private System.Windows.Forms.Label labelFellowship;
		private System.Windows.Forms.Label labelWillpower;
		private System.Windows.Forms.Label labelPerception;
		private System.Windows.Forms.Label labelIntelligence;
		private System.Windows.Forms.Label labelAgility;
		private System.Windows.Forms.Label labelToughness;
		private System.Windows.Forms.Label labelStrength;
		private System.Windows.Forms.Label labelWeaponSkill;
		private System.Windows.Forms.Label labelBallisticSkill;
		private System.Windows.Forms.RichTextBox richTextBoxWeaponSkill;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.RichTextBox richTextBoxCurrentlyKnown;
		private System.Windows.Forms.Label labelCurrentlyKnown;
		private System.Windows.Forms.Button buttonSaveAsJson;
		private System.Windows.Forms.Button buttonSaveAsXml;
		private System.Windows.Forms.ListBox listBoxTalantDetails;
		private System.Windows.Forms.RichTextBox richTextBoxPrerequisites;
		private System.Windows.Forms.RichTextBox richTextBoxAptitudes;
		private System.Windows.Forms.RichTextBox richTextBoxTier;
		private System.Windows.Forms.RichTextBox richTextBoxName;
		private System.Windows.Forms.RichTextBox richTextBoxDetails;
		private System.Windows.Forms.RichTextBox richTextBoxBenefit;
		private System.Windows.Forms.Label labelTier;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPrerequisites;
		private System.Windows.Forms.Label labelAptitudes;
		private System.Windows.Forms.Label labelBenefit;
		private System.Windows.Forms.Label labelDetails;
		private System.Windows.Forms.ListBox listBoxCharacters;
		private System.Windows.Forms.Button buttonSaveCharacterJson;
	}
}

