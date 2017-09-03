using System;
using System.Windows.Forms;

namespace Char_Generator
{
	public partial class AddExperience : Form
	{
		Character selectedCharacter;

		public AddExperience(Character selectedCharacter)
		{
			InitializeComponent();
			this.selectedCharacter = selectedCharacter;
		}

		public Character getSelectedCharacter()
		{
			return selectedCharacter;
		}

		void textBoxAddExperience_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
				return;
			e.Handled = true;
		}

		void buttonAdd_Click(object sender, EventArgs e)
		{
			selectedCharacter.experienceLeft += int.Parse(textBoxAddExperence.Text);
			Hide();
		}

		void buttonCancel_Click(object sender, EventArgs e){Hide();}
	}
}
