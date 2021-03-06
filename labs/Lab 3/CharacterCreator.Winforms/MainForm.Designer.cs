﻿/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 3
 */
namespace CharacterCreator.Winforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miExit = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacterAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacterEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miCharacterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._lbRoster = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miCharacter,
            this._miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(37, 20);
            this._miFile.Text = "&File";
            // 
            // _miExit
            // 
            this._miExit.Name = "_miExit";
            this._miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miExit.Size = new System.Drawing.Size(135, 22);
            this._miExit.Text = "E&xit";
            // 
            // _miCharacter
            // 
            this._miCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miCharacterAdd,
            this._miCharacterEdit,
            this.toolStripSeparator1,
            this._miCharacterDelete});
            this._miCharacter.Name = "_miCharacter";
            this._miCharacter.Size = new System.Drawing.Size(75, 20);
            this._miCharacter.Text = "&Characters";
            // 
            // _miCharacterAdd
            // 
            this._miCharacterAdd.Name = "_miCharacterAdd";
            this._miCharacterAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._miCharacterAdd.Size = new System.Drawing.Size(139, 22);
            this._miCharacterAdd.Text = "&Add";
            // 
            // _miCharacterEdit
            // 
            this._miCharacterEdit.Name = "_miCharacterEdit";
            this._miCharacterEdit.Size = new System.Drawing.Size(139, 22);
            this._miCharacterEdit.Text = "&Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // _miCharacterDelete
            // 
            this._miCharacterDelete.Name = "_miCharacterDelete";
            this._miCharacterDelete.Size = new System.Drawing.Size(139, 22);
            this._miCharacterDelete.Text = "&Delete";
            // 
            // _miHelp
            // 
            this._miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this._miHelp.Name = "_miHelp";
            this._miHelp.Size = new System.Drawing.Size(44, 20);
            this._miHelp.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(126, 22);
            this._miHelpAbout.Text = "&About";
            // 
            // _lbRoster
            // 
            this._lbRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbRoster.FormattingEnabled = true;
            this._lbRoster.ItemHeight = 15;
            this._lbRoster.Location = new System.Drawing.Point(0, 24);
            this._lbRoster.Name = "_lbRoster";
            this._lbRoster.Size = new System.Drawing.Size(284, 387);
            this._lbRoster.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this._lbRoster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miExit;
        private System.Windows.Forms.ToolStripMenuItem _miCharacter;
        private System.Windows.Forms.ToolStripMenuItem _miHelp;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterAdd;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterDelete;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _lbRoster;
    }
}

