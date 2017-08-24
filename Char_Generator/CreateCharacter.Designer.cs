namespace Char_Generator
{
	partial class CreateCharacter
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
			this.listBoxRegiment = new System.Windows.Forms.ListBox();
			this.textBoxRegiment = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxSpecialty = new System.Windows.Forms.RichTextBox();
			this.listBoxSpecialty = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBoxDemeanor = new System.Windows.Forms.RichTextBox();
			this.listBoxDemeanor = new System.Windows.Forms.ListBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.RichTextBox();
			this.textBoxDescription = new System.Windows.Forms.RichTextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxRegiment
			// 
			this.listBoxRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxRegiment.FormattingEnabled = true;
			this.listBoxRegiment.Location = new System.Drawing.Point(6, 19);
			this.listBoxRegiment.Name = "listBoxRegiment";
			this.listBoxRegiment.Size = new System.Drawing.Size(277, 121);
			this.listBoxRegiment.TabIndex = 75;
			this.listBoxRegiment.SelectedIndexChanged += new System.EventHandler(this.listBoxRegiment_SelectedIndexChanged);
			// 
			// textBoxRegiment
			// 
			this.textBoxRegiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxRegiment.Location = new System.Drawing.Point(289, 19);
			this.textBoxRegiment.Name = "textBoxRegiment";
			this.textBoxRegiment.ReadOnly = true;
			this.textBoxRegiment.Size = new System.Drawing.Size(478, 121);
			this.textBoxRegiment.TabIndex = 76;
			this.textBoxRegiment.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBoxRegiment);
			this.groupBox2.Controls.Add(this.textBoxRegiment);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(773, 149);
			this.groupBox2.TabIndex = 80;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Regiment";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxSpecialty);
			this.groupBox1.Controls.Add(this.listBoxSpecialty);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(12, 167);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(773, 149);
			this.groupBox1.TabIndex = 81;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Specialty";
			// 
			// textBoxSpecialty
			// 
			this.textBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSpecialty.Location = new System.Drawing.Point(289, 19);
			this.textBoxSpecialty.Name = "textBoxSpecialty";
			this.textBoxSpecialty.ReadOnly = true;
			this.textBoxSpecialty.Size = new System.Drawing.Size(478, 121);
			this.textBoxSpecialty.TabIndex = 77;
			this.textBoxSpecialty.Text = "";
			// 
			// listBoxSpecialty
			// 
			this.listBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxSpecialty.FormattingEnabled = true;
			this.listBoxSpecialty.Location = new System.Drawing.Point(6, 19);
			this.listBoxSpecialty.Name = "listBoxSpecialty";
			this.listBoxSpecialty.Size = new System.Drawing.Size(277, 121);
			this.listBoxSpecialty.TabIndex = 77;
			this.listBoxSpecialty.SelectedIndexChanged += new System.EventHandler(this.listBoxSpecialty_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBoxDemeanor);
			this.groupBox3.Controls.Add(this.listBoxDemeanor);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(12, 322);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(773, 149);
			this.groupBox3.TabIndex = 81;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Demeanor";
			// 
			// textBoxDemeanor
			// 
			this.textBoxDemeanor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDemeanor.Location = new System.Drawing.Point(289, 19);
			this.textBoxDemeanor.Name = "textBoxDemeanor";
			this.textBoxDemeanor.ReadOnly = true;
			this.textBoxDemeanor.Size = new System.Drawing.Size(478, 121);
			this.textBoxDemeanor.TabIndex = 78;
			this.textBoxDemeanor.Text = "";
			// 
			// listBoxDemeanor
			// 
			this.listBoxDemeanor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxDemeanor.FormattingEnabled = true;
			this.listBoxDemeanor.Location = new System.Drawing.Point(6, 19);
			this.listBoxDemeanor.Name = "listBoxDemeanor";
			this.listBoxDemeanor.Size = new System.Drawing.Size(277, 121);
			this.listBoxDemeanor.TabIndex = 78;
			this.listBoxDemeanor.SelectedIndexChanged += new System.EventHandler(this.listBoxDemeanor_SelectedIndexChanged);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(903, 447);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 83;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(794, 22);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(184, 20);
			this.textBoxName.TabIndex = 104;
			this.textBoxName.Text = "";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.Location = new System.Drawing.Point(794, 61);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(184, 255);
			this.textBoxDescription.TabIndex = 101;
			this.textBoxDescription.Text = "";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(791, 6);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 96;
			this.labelName.Text = "Name";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDescription.Location = new System.Drawing.Point(791, 45);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(60, 13);
			this.labelDescription.TabIndex = 100;
			this.labelDescription.Text = "Description";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(822, 447);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 112;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// CreateCharacter
			// 
			this.ClientSize = new System.Drawing.Size(990, 482);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "CreateCharacter";
			this.Load += new System.EventHandler(this.CreateCharacter_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxRegiment;
		private System.Windows.Forms.RichTextBox textBoxRegiment;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox textBoxSpecialty;
		private System.Windows.Forms.ListBox listBoxSpecialty;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RichTextBox textBoxDemeanor;
		private System.Windows.Forms.ListBox listBoxDemeanor;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.RichTextBox textBoxName;
		private System.Windows.Forms.RichTextBox textBoxDescription;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Button buttonCancel;
	}
}
