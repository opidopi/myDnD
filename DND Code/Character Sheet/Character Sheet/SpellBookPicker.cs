using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Sheet
{
    public partial class SpellBookPicker : Form
    {
        CharacterSheet charSheetMain;

        public SpellBookPicker(CharacterSheet pCharSheet)
        {
            charSheetMain = pCharSheet;
            InitializeComponent();
            foreach (CharSpellBook sb in charSheetMain.player.SpellBooks)
                BookComboBox.Items.Add(sb);
            BookComboBox.Items.Add("New");
            BookComboBox.SelectedIndex = 0;
            if (!BookComboBox.SelectedItem.Equals("New"))
                BookNameBox.Text = ((CharSpellBook)BookComboBox.SelectedItem).Name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            CharSpellBook ssb = null;
            if (string.IsNullOrWhiteSpace(BookNameBox.Text))
                MessageBox.Show("Spellbook Name cannot be blank");
            else if(BookNameBox.Text.ToLower().Equals("new"))
                MessageBox.Show("Spellbook Name cannot be 'New'");
            else
            {
                if(BookComboBox.SelectedItem.Equals("New"))
                {
                    ssb = new CharSpellBook();
                    ssb.Name = BookNameBox.Text;
                    charSheetMain.player.SpellBooks.Add(ssb);
                }
                else
                {
                    ssb = BookComboBox.SelectedItem as CharSpellBook;
                    ssb.Name = BookNameBox.Text;
                }
                SpellBook sb = new SpellBook(charSheetMain, ssb);
                sb.Show();
                charSheetMain.openSpellBooks.Add(sb);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
