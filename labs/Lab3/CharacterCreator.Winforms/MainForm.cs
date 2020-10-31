/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 3
 */
using System;
using System.Linq;
using System.Windows.Forms;

using CharacterCreator.Memory;


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
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            int count = RefreshUI();
            if (count == 0)
            {

            };
        }
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        private ICharacterRoster _character = new MemoryCharacterDatabase();
        private void AddCharacter ( Character character )
        {
            var newCharacter = _character.Add(character, out var message);
            if (newCharacter == null)
            {
                MessageBox.Show(this, message, "Add Failed", MessageBoxButtons.OK);
                return;
            };
        }
        private void DeleteCharacter ( int id )
        {
            _character.Delete(id);
        }
        private void EditCharacter ( int id, Character character )
        {
            var error = _character.Update(id, character);
            if (String.IsNullOrEmpty(error))
            {
                RefreshUI();
                return;
            };
            MessageBox.Show(this, error, "Edit Character", MessageBoxButtons.OK);
        }
        private Character GetSelectedCharacter ()
        {
            return _lbRoster.SelectedItem as Character;
        }
        private int RefreshUI ()
        {
            var items = _character.GetAll().ToArray();

            _lbRoster.DataSource  = items;

            return items.Length;
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            AddCharacter(null);
        }
        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (_character == null)
                return;

            switch (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            };
            DeleteCharacter(character.Id);
            RefreshUI();
        }
        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (_character == null)
                return;

            var form = new CharacterForm(character, "Edit Character");

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            EditCharacter(character.Id, form.Character);
        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }
    }
}
