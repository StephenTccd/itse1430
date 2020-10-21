/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
            Character character;
            character = new Character();
           
            character.Name = "Axe";
            character.Description = "Brave Warrior";
            
            _miCharacterAdd.Click += OnCharacterAdd;
            _miCharacterEdit.Click += OnCharacterEdit;
            _miCharacterDelete.Click += OnCharacterDelete;
            _miHelpAbout.Click += OnHelpAbout;
            _miExit.Click += OnFileExit;
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }
        private Character _character;

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            _character = form.Character;
            MessageBox.Show("Save successful");
        }
        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            switch (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            };
            _character = null;
        }
        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            var form = new CharacterForm(_character, "Edit Character");

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;


            _character = form.Character;
            MessageBox.Show("Save successful");
        }
        private void RefreshRoster ( object sender, EventArgs e )
        {
            var roster = new BindingList<Character>();
            roster.Add(_character);

            _lbRoster.DataSource = roster;
            _lbRoster.DisplayMember = "Name";
        }
        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }
    }
}
