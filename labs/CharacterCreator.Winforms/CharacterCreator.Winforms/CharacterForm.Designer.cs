namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this._name = new System.Windows.Forms.Label();
            this._profession = new System.Windows.Forms.Label();
            this._race = new System.Windows.Forms.Label();
            this._attributes = new System.Windows.Forms.Label();
            this._description = new System.Windows.Forms.Label();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._strength = new System.Windows.Forms.Label();
            this._intellegence = new System.Windows.Forms.Label();
            this._agility = new System.Windows.Forms.Label();
            this._constitution = new System.Windows.Forms.Label();
            this._charisma = new System.Windows.Forms.Label();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntellegence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(48, 40);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(39, 15);
            this._name.TabIndex = 0;
            this._name.Text = "Name";
            this._name.Click += new System.EventHandler(this.label1_Click);
            // 
            // _profession
            // 
            this._profession.AutoSize = true;
            this._profession.Location = new System.Drawing.Point(48, 86);
            this._profession.Name = "_profession";
            this._profession.Size = new System.Drawing.Size(62, 15);
            this._profession.TabIndex = 1;
            this._profession.Text = "Profession";
            // 
            // _race
            // 
            this._race.AutoSize = true;
            this._race.Location = new System.Drawing.Point(48, 131);
            this._race.Name = "_race";
            this._race.Size = new System.Drawing.Size(32, 15);
            this._race.TabIndex = 2;
            this._race.Text = "Race";
            // 
            // _attributes
            // 
            this._attributes.AutoSize = true;
            this._attributes.Location = new System.Drawing.Point(48, 180);
            this._attributes.Name = "_attributes";
            this._attributes.Size = new System.Drawing.Size(59, 15);
            this._attributes.TabIndex = 3;
            this._attributes.Text = "Attributes";
            // 
            // _description
            // 
            this._description.AutoSize = true;
            this._description.Location = new System.Drawing.Point(48, 345);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(67, 15);
            this._description.TabIndex = 4;
            this._description.Text = "Description";
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(146, 78);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(107, 23);
            this._comboProfession.TabIndex = 5;
            this._comboProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProfession);
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(146, 123);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(107, 23);
            this._comboRace.TabIndex = 6;
            this._comboRace.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this._comboRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(146, 32);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(185, 23);
            this._txtName.TabIndex = 7;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(151, 345);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(180, 95);
            this._txtDescription.TabIndex = 8;
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(204, 474);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(67, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(299, 474);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(66, 23);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // _strength
            // 
            this._strength.AutoSize = true;
            this._strength.Location = new System.Drawing.Point(146, 183);
            this._strength.Name = "_strength";
            this._strength.Size = new System.Drawing.Size(58, 15);
            this._strength.TabIndex = 11;
            this._strength.Text = "Strength :";
            // 
            // _intellegence
            // 
            this._intellegence.AutoSize = true;
            this._intellegence.Location = new System.Drawing.Point(146, 215);
            this._intellegence.Name = "_intellegence";
            this._intellegence.Size = new System.Drawing.Size(77, 15);
            this._intellegence.TabIndex = 12;
            this._intellegence.Text = "Intellegence :";
            // 
            // _agility
            // 
            this._agility.AutoSize = true;
            this._agility.Location = new System.Drawing.Point(146, 247);
            this._agility.Name = "_agility";
            this._agility.Size = new System.Drawing.Size(47, 15);
            this._agility.TabIndex = 13;
            this._agility.Text = "Agility :";
            this._agility.Click += new System.EventHandler(this._agility_Click);
            // 
            // _constitution
            // 
            this._constitution.AutoSize = true;
            this._constitution.Location = new System.Drawing.Point(144, 278);
            this._constitution.Name = "_constitution";
            this._constitution.Size = new System.Drawing.Size(79, 15);
            this._constitution.TabIndex = 14;
            this._constitution.Text = "Constitution :";
            // 
            // _charisma
            // 
            this._charisma.AutoSize = true;
            this._charisma.Location = new System.Drawing.Point(146, 309);
            this._charisma.Name = "_charisma";
            this._charisma.Size = new System.Drawing.Size(63, 15);
            this._charisma.TabIndex = 15;
            this._charisma.Text = "Charisma :";
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(241, 180);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(30, 23);
            this._txtStrength.TabIndex = 16;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateStrength);
            // 
            // _txtIntellegence
            // 
            this._txtIntellegence.Location = new System.Drawing.Point(241, 212);
            this._txtIntellegence.Name = "_txtIntellegence";
            this._txtIntellegence.Size = new System.Drawing.Size(30, 23);
            this._txtIntellegence.TabIndex = 17;
            this._txtIntellegence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateIntellegence);
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(241, 244);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(30, 23);
            this._txtAgility.TabIndex = 18;
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAgility);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(241, 275);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(30, 23);
            this._txtConstitution.TabIndex = 19;
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateConstitution);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(241, 306);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(30, 23);
            this._txtCharisma.TabIndex = 20;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCharisma);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(594, 582);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntellegence);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._charisma);
            this.Controls.Add(this._constitution);
            this.Controls.Add(this._agility);
            this.Controls.Add(this._intellegence);
            this.Controls.Add(this._strength);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._description);
            this.Controls.Add(this._attributes);
            this.Controls.Add(this._race);
            this.Controls.Add(this._profession);
            this.Controls.Add(this._name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.Label _profession;
        private System.Windows.Forms.Label _race;
        private System.Windows.Forms.Label _attributes;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.Label _charisma;
        private System.Windows.Forms.Label _constitution;
        private System.Windows.Forms.Label _agility;
        private System.Windows.Forms.Label _intellegence;
        private System.Windows.Forms.Label _strength;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtIntellegence;
        private System.Windows.Forms.TextBox _txtStrength;
    }
}