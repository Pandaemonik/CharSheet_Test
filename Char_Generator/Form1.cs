using System;
using System.Windows.Forms;

namespace Char_Generator
{
    public partial class charGenMain : Form
    {
        Talents testTalents;

        public charGenMain()
        {
            InitializeComponent();
        }
         
        private void loadTalantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testTalents = new Talents();
            displayInDetailsToolStripMenuItem.Enabled = true;
            displayInLabelToolStripMenuItem.Enabled = true;
        }

        private void displayInLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            testTalents.TalentList.ForEach(x => richTextBoxCurrentlyKnown.Text += x.ToString() + "\n");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveTalantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"E:\C#_Projects\Char_Generator\Char_Generator\Talents_XML.xml", testTalents.SerializeXML());
        }

        private void displayInDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testTalents.TalentList.ForEach(x => listBoxTalantDetails.Items.Add(x.Name));
        }

        private void listBoxTalantDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Talent curSelected = testTalents.Find(listBoxTalantDetails.Text);
            richTextBoxName.Text = curSelected.Name;
            richTextBoxTier.Text = curSelected.Tier;
            richTextBoxAptitudes.Text = curSelected.Aptitude1 + ", " + curSelected.Aptitude2;
            richTextBoxPrerequisites.Text = curSelected.Prerequisites;
            richTextBoxBenefit.Text = curSelected.Benefit;
            richTextBoxDetails.Text = curSelected.Details;
        }

        private void buttonSaveAsXml_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"E:\C#_Projects\Char_Generator\Char_Generator\Talents_XML.xml", testTalents.SerializeXML());
        }

        private void buttonSaveAsJson_Click(object sender, EventArgs e)
        {
                System.IO.File.WriteAllText(@"E:\C#_Projects\Char_Generator\Char_Generator\Talents_JSON.json", testTalents.SerializeJSON());
        }
    }
}
