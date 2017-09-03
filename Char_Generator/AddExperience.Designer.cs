namespace Char_Generator
{
	partial class AddExperience
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
			this.textBoxAddExperence = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxAddExperence
			// 
			this.textBoxAddExperence.Location = new System.Drawing.Point(111, 6);
			this.textBoxAddExperence.Name = "textBoxAddExperence";
			this.textBoxAddExperence.Size = new System.Drawing.Size(100, 20);
			this.textBoxAddExperence.TabIndex = 0;
			this.textBoxAddExperence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddExperience_KeyPress);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(111, 32);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(15, 32);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Experience to add";
			// 
			// AddExperience
			// 
			this.ClientSize = new System.Drawing.Size(223, 66);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxAddExperence);
			this.Name = "AddExperience";
			this.Text = "Add experience";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxAddExperence;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
	}
}
