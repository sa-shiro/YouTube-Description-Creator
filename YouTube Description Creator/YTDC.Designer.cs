namespace YouTube_Description_Creator
{
    partial class YTDC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SongBox = new System.Windows.Forms.TextBox();
            this.ModeBox = new System.Windows.Forms.TextBox();
            this.BeatmapBox = new System.Windows.Forms.TextBox();
            this.PlayerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.TextBox();
            this.EtcBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Enabled = false;
            this.TitleBox.Location = new System.Drawing.Point(127, 21);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(398, 20);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "osu!";
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Song:";
            // 
            // SongBox
            // 
            this.SongBox.Location = new System.Drawing.Point(127, 47);
            this.SongBox.Name = "SongBox";
            this.SongBox.Size = new System.Drawing.Size(398, 20);
            this.SongBox.TabIndex = 3;
            this.SongBox.TextChanged += new System.EventHandler(this.SongBox_TextChanged);
            // 
            // ModeBox
            // 
            this.ModeBox.Location = new System.Drawing.Point(127, 73);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(398, 20);
            this.ModeBox.TabIndex = 4;
            this.ModeBox.TextChanged += new System.EventHandler(this.ModeBox_TextChanged);
            // 
            // BeatmapBox
            // 
            this.BeatmapBox.Location = new System.Drawing.Point(127, 99);
            this.BeatmapBox.Name = "BeatmapBox";
            this.BeatmapBox.Size = new System.Drawing.Size(398, 20);
            this.BeatmapBox.TabIndex = 5;
            this.BeatmapBox.TextChanged += new System.EventHandler(this.BeatmapBox_TextChanged);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Location = new System.Drawing.Point(127, 125);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(398, 20);
            this.PlayerBox.TabIndex = 6;
            this.PlayerBox.TextChanged += new System.EventHandler(this.PlayerBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mode | Mods:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beatmap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player Profile:";
            // 
            // SourceBox
            // 
            this.SourceBox.Location = new System.Drawing.Point(12, 267);
            this.SourceBox.Multiline = true;
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.ReadOnly = true;
            this.SourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SourceBox.Size = new System.Drawing.Size(513, 142);
            this.SourceBox.TabIndex = 11;
            // 
            // EtcBox
            // 
            this.EtcBox.Location = new System.Drawing.Point(12, 164);
            this.EtcBox.Multiline = true;
            this.EtcBox.Name = "EtcBox";
            this.EtcBox.Size = new System.Drawing.Size(510, 97);
            this.EtcBox.TabIndex = 12;
            this.EtcBox.TextChanged += new System.EventHandler(this.EtcBox_TextChanged);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 148);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 13);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 415);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset/Clear";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // YTDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.EtcBox);
            this.Controls.Add(this.SourceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.BeatmapBox);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.SongBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YTDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YTDC for osu!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SongBox;
        private System.Windows.Forms.TextBox ModeBox;
        private System.Windows.Forms.TextBox BeatmapBox;
        private System.Windows.Forms.TextBox PlayerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SourceBox;
        private System.Windows.Forms.TextBox EtcBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button ResetButton;
    }
}

