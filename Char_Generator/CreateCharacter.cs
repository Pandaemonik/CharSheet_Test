using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Char_Generator
{
	public partial class CreateCharacter : Form
	{
		List<Regiment> regiments = new List<Regiment>();
		List<Specialty> specialtyes = new List<Specialty>();
		List<string> demeanors = new List<string>();
		Character selectedCharacter;
		Character newCharacter;

		public CreateCharacter(Character selectedCharacter)
		{
			InitializeComponent();
			this.selectedCharacter = selectedCharacter;
			//TODO Load Regiments
			//TODO Load Specialties
			//TODO Load Demeanors
		}

		public Character getSelectedCharacter()
		{
			return selectedCharacter;
		}

		private void CreateCharacter_Load(object sender, EventArgs e)
		{
			//TODO Display regiments in listbox
			//TODO display specialty in listbox
			//TODO display demeanors in listbox
			//TODO disable create button 
		}
		
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			//TODO Load regiment parts to newCharacter
			//TODO Load specialty info to newCharacter
			//TODO Load demeanor info to newCharacter
			//TODO Load name to newCharacter
			//TODO Load Details to newCharacter
			//TODO Save selected Character
			//TODO Assign newCharacter to selectedCharacter
			Hide();
		}

		private void listBoxRegiment_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO Display regiment.toString() in textBoxRegiment
		}

		private void listBoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO Display specialty.toString() in textBoxSpecialty
		}

		private void listBoxDemeanor_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO Display demeanor in textBox Demeanor
		}
	}
}
