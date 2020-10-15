﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }

        public CharacterForm ( Character character ) : this(character, null)
        {

        }

        public CharacterForm (Character character, string title ) : this()
        {
            Character = character;
            Text = title ?? "Create Character";
        }
        public virtual Character Character { get; set; }
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _comboProfession.SelectedText = Character.Profession;
                _comboRace.SelectedText = Character.Race;
                _txtDescription.Text = Character.Description;
                _txtStrength.Text = Character.Strength.ToString();
                _txtIntellegence.Text = Character.Intellegence.ToString();
                _txtAgility.Text = Character.Agility.ToString();
                _txtConstitution.Text = Character.Constitution.ToString();
                _txtCharisma.Text = Character.Charisma.ToString();
            };

            ValidateChildren();
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };

            var button = sender as Button;
            if (button == null)
                return;

            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _comboProfession.SelectedText;
            character.Race = _comboRace.SelectedText;
            character.Description = _txtDescription.Text;
            character.Strength = ReadAsInt32(_txtStrength);
            character.Intellegence = ReadAsInt32(_txtIntellegence);
            character.Agility = ReadAsInt32(_txtAgility);
            character.Constitution = ReadAsInt32(_txtConstitution);
            character.Charisma = ReadAsInt32(_txtCharisma);


            var nameLength = Character.MaximumNameLength;
            var descriptionLength = character.MaximumDescriptionLength;
           
            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(this, error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            };
            Character = character;
            Close();
        }
        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;
            
            return -1;
        }
        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Profession is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Race is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateStrength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            {
                _errors.SetError(control, "Strength must be >= 0");
                e.Cancel = true;
            } else if (value > 100)
            {
                _errors.SetError(control, "Strength must be <= 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateIntellegence ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            { 
                _errors.SetError(control, "Intellegence must be >= 0");
                e.Cancel = true;
            } else if (value > 100)
            {
                _errors.SetError(control, "Intellegence must be <= 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateAgility ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            {
                _errors.SetError(control, "Agility must be >= 0");
                e.Cancel = true;
            } else if (value > 100)
            {
                _errors.SetError(control, "Agility must be <= 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateConstitution ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            {
                _errors.SetError(control, "Constitution must be >= 0");
                e.Cancel = true;
            } else if (value > 100)
            {
                _errors.SetError(control, "Constitution must be <= 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidateCharisma ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            {
                _errors.SetError(control, "Charisma must be >= 0");
                e.Cancel = true;
            } else if (value > 100)
            {
                _errors.SetError(control, "Charisma must be <= 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void _agility_Click ( object sender, EventArgs e )
        {

        }
        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void comboBox2_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
    }
}
