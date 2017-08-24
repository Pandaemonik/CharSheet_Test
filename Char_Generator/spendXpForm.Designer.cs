namespace Char_Generator
{
	partial class spendXpForm
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
			this.listBoxTalents = new System.Windows.Forms.ListBox();
			this.listBoxSkills = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonBuySkill = new System.Windows.Forms.Button();
			this.textBoxSkillCost = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonBuyTalents = new System.Windows.Forms.Button();
			this.textBoxTalentCost = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonBuyCharacteristics = new System.Windows.Forms.Button();
			this.textBoxCharacteristicCost = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listBoxCharacteristics = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxSelected = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonFinalize = new System.Windows.Forms.Button();
			this.buttonRefund = new System.Windows.Forms.Button();
			this.textBoxTotalXp = new System.Windows.Forms.RichTextBox();
			this.textBoxAvailableXp = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listBoxBuyList = new System.Windows.Forms.ListBox();
			this.textBoxTalent = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxTalents
			// 
			this.listBoxTalents.FormattingEnabled = true;
			this.listBoxTalents.Location = new System.Drawing.Point(6, 19);
			this.listBoxTalents.Name = "listBoxTalents";
			this.listBoxTalents.Size = new System.Drawing.Size(188, 173);
			this.listBoxTalents.TabIndex = 0;
			this.listBoxTalents.SelectedIndexChanged += new System.EventHandler(this.listBoxTalents_SelectedIndexChanged);
			// 
			// listBoxSkills
			// 
			this.listBoxSkills.FormattingEnabled = true;
			this.listBoxSkills.Location = new System.Drawing.Point(6, 19);
			this.listBoxSkills.Name = "listBoxSkills";
			this.listBoxSkills.Size = new System.Drawing.Size(188, 355);
			this.listBoxSkills.TabIndex = 1;
			this.listBoxSkills.SelectedIndexChanged += new System.EventHandler(this.listBoxSkills_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonBuySkill);
			this.groupBox1.Controls.Add(this.textBoxSkillCost);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.listBoxSkills);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 417);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Skills";
			// 
			// buttonBuySkill
			// 
			this.buttonBuySkill.Location = new System.Drawing.Point(119, 388);
			this.buttonBuySkill.Name = "buttonBuySkill";
			this.buttonBuySkill.Size = new System.Drawing.Size(75, 23);
			this.buttonBuySkill.TabIndex = 97;
			this.buttonBuySkill.Text = "Buy";
			this.buttonBuySkill.UseVisualStyleBackColor = true;
			this.buttonBuySkill.Click += new System.EventHandler(this.buttonBuySkill_Click);
			// 
			// textBoxSkillCost
			// 
			this.textBoxSkillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSkillCost.Location = new System.Drawing.Point(46, 390);
			this.textBoxSkillCost.Name = "textBoxSkillCost";
			this.textBoxSkillCost.ReadOnly = true;
			this.textBoxSkillCost.Size = new System.Drawing.Size(67, 20);
			this.textBoxSkillCost.TabIndex = 92;
			this.textBoxSkillCost.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 393);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cost :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxTalent);
			this.groupBox2.Controls.Add(this.buttonBuyTalents);
			this.groupBox2.Controls.Add(this.textBoxTalentCost);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.listBoxTalents);
			this.groupBox2.Location = new System.Drawing.Point(218, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 417);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Talents";
			// 
			// buttonBuyTalents
			// 
			this.buttonBuyTalents.Location = new System.Drawing.Point(119, 388);
			this.buttonBuyTalents.Name = "buttonBuyTalents";
			this.buttonBuyTalents.Size = new System.Drawing.Size(75, 23);
			this.buttonBuyTalents.TabIndex = 97;
			this.buttonBuyTalents.Text = "Buy";
			this.buttonBuyTalents.UseVisualStyleBackColor = true;
			this.buttonBuyTalents.Click += new System.EventHandler(this.buttonBuyTalents_Click);
			// 
			// textBoxTalentCost
			// 
			this.textBoxTalentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTalentCost.Location = new System.Drawing.Point(46, 389);
			this.textBoxTalentCost.Name = "textBoxTalentCost";
			this.textBoxTalentCost.ReadOnly = true;
			this.textBoxTalentCost.Size = new System.Drawing.Size(67, 20);
			this.textBoxTalentCost.TabIndex = 92;
			this.textBoxTalentCost.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 393);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cost :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonBuyCharacteristics);
			this.groupBox3.Controls.Add(this.textBoxCharacteristicCost);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.listBoxCharacteristics);
			this.groupBox3.Location = new System.Drawing.Point(424, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 417);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Characteristics";
			// 
			// buttonBuyCharacteristics
			// 
			this.buttonBuyCharacteristics.Location = new System.Drawing.Point(119, 386);
			this.buttonBuyCharacteristics.Name = "buttonBuyCharacteristics";
			this.buttonBuyCharacteristics.Size = new System.Drawing.Size(75, 23);
			this.buttonBuyCharacteristics.TabIndex = 96;
			this.buttonBuyCharacteristics.Text = "Buy";
			this.buttonBuyCharacteristics.UseVisualStyleBackColor = true;
			this.buttonBuyCharacteristics.Click += new System.EventHandler(this.buttonBuyCharacteristics_Click);
			// 
			// textBoxCharacteristicCost
			// 
			this.textBoxCharacteristicCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCharacteristicCost.Location = new System.Drawing.Point(46, 388);
			this.textBoxCharacteristicCost.Name = "textBoxCharacteristicCost";
			this.textBoxCharacteristicCost.ReadOnly = true;
			this.textBoxCharacteristicCost.Size = new System.Drawing.Size(67, 20);
			this.textBoxCharacteristicCost.TabIndex = 92;
			this.textBoxCharacteristicCost.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 391);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cost :";
			// 
			// listBoxCharacteristics
			// 
			this.listBoxCharacteristics.FormattingEnabled = true;
			this.listBoxCharacteristics.Location = new System.Drawing.Point(6, 19);
			this.listBoxCharacteristics.Name = "listBoxCharacteristics";
			this.listBoxCharacteristics.Size = new System.Drawing.Size(188, 355);
			this.listBoxCharacteristics.TabIndex = 1;
			this.listBoxCharacteristics.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacteristics_SelectedIndexChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxSelected);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.buttonFinalize);
			this.groupBox4.Controls.Add(this.buttonRefund);
			this.groupBox4.Controls.Add(this.textBoxTotalXp);
			this.groupBox4.Controls.Add(this.textBoxAvailableXp);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.listBoxBuyList);
			this.groupBox4.Location = new System.Drawing.Point(630, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 417);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Buy List";
			// 
			// textBoxSelected
			// 
			this.textBoxSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSelected.Location = new System.Drawing.Point(82, 306);
			this.textBoxSelected.Name = "textBoxSelected";
			this.textBoxSelected.ReadOnly = true;
			this.textBoxSelected.Size = new System.Drawing.Size(112, 20);
			this.textBoxSelected.TabIndex = 99;
			this.textBoxSelected.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 309);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 98;
			this.label6.Text = "Selected Cost:";
			// 
			// buttonFinalize
			// 
			this.buttonFinalize.Location = new System.Drawing.Point(119, 388);
			this.buttonFinalize.Name = "buttonFinalize";
			this.buttonFinalize.Size = new System.Drawing.Size(75, 23);
			this.buttonFinalize.TabIndex = 97;
			this.buttonFinalize.Text = "Finalize";
			this.buttonFinalize.UseVisualStyleBackColor = true;
			this.buttonFinalize.Click += new System.EventHandler(this.buttonFinalize_Click);
			// 
			// buttonRefund
			// 
			this.buttonRefund.Location = new System.Drawing.Point(9, 388);
			this.buttonRefund.Name = "buttonRefund";
			this.buttonRefund.Size = new System.Drawing.Size(75, 23);
			this.buttonRefund.TabIndex = 95;
			this.buttonRefund.Text = "Refund";
			this.buttonRefund.UseVisualStyleBackColor = true;
			this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
			// 
			// textBoxTotalXp
			// 
			this.textBoxTotalXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTotalXp.Location = new System.Drawing.Point(82, 358);
			this.textBoxTotalXp.Name = "textBoxTotalXp";
			this.textBoxTotalXp.ReadOnly = true;
			this.textBoxTotalXp.Size = new System.Drawing.Size(112, 20);
			this.textBoxTotalXp.TabIndex = 94;
			this.textBoxTotalXp.Text = "0";
			// 
			// textBoxAvailableXp
			// 
			this.textBoxAvailableXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAvailableXp.Location = new System.Drawing.Point(82, 332);
			this.textBoxAvailableXp.Name = "textBoxAvailableXp";
			this.textBoxAvailableXp.ReadOnly = true;
			this.textBoxAvailableXp.Size = new System.Drawing.Size(112, 20);
			this.textBoxAvailableXp.TabIndex = 93;
			this.textBoxAvailableXp.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 335);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Exp available :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 361);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Total Cost :";
			// 
			// listBoxBuyList
			// 
			this.listBoxBuyList.FormattingEnabled = true;
			this.listBoxBuyList.Location = new System.Drawing.Point(6, 19);
			this.listBoxBuyList.Name = "listBoxBuyList";
			this.listBoxBuyList.Size = new System.Drawing.Size(188, 277);
			this.listBoxBuyList.TabIndex = 1;
			this.listBoxBuyList.SelectedIndexChanged += new System.EventHandler(this.listBoxBuyList_SelectedIndexChanged);
			// 
			// textBoxTalent
			// 
			this.textBoxTalent.Location = new System.Drawing.Point(6, 198);
			this.textBoxTalent.Name = "textBoxTalent";
			this.textBoxTalent.ReadOnly = true;
			this.textBoxTalent.Size = new System.Drawing.Size(188, 176);
			this.textBoxTalent.TabIndex = 98;
			this.textBoxTalent.Text = "";
			// 
			// spendXpForm
			// 
			this.ClientSize = new System.Drawing.Size(849, 441);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "spendXpForm";
			this.Load += new System.EventHandler(this.spendXpForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxTalents;
		private System.Windows.Forms.ListBox listBoxSkills;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBoxCharacteristics;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBoxBuyList;
		private System.Windows.Forms.Button buttonBuySkill;
		private System.Windows.Forms.RichTextBox textBoxSkillCost;
		private System.Windows.Forms.Button buttonBuyTalents;
		private System.Windows.Forms.RichTextBox textBoxTalentCost;
		private System.Windows.Forms.Button buttonBuyCharacteristics;
		private System.Windows.Forms.RichTextBox textBoxCharacteristicCost;
		private System.Windows.Forms.Button buttonFinalize;
		private System.Windows.Forms.Button buttonRefund;
		private System.Windows.Forms.RichTextBox textBoxTotalXp;
		private System.Windows.Forms.RichTextBox textBoxAvailableXp;
		private System.Windows.Forms.RichTextBox textBoxSelected;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox textBoxTalent;
	}
}
