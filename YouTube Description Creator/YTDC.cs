using System;
using System.Windows.Forms;
using System.IO;
using YouTube_Description_Creator.Properties;

namespace YouTube_Description_Creator
{
    public partial class YTDC : Form
    {
        public string line = "\r\n__________________________________________________________________________________\r\n";
        public string title  = "Title:  ";
        public string song = "\r\nSong: ";
        public string mode = "\r\nMode / Mod:   ";
        public string beatmap = "\r\nBeatmap:   ";
        public string profile = "\r\nPlayer Profile:    ";

        public YTDC()
        {
            InitializeComponent();
            SourceBox.Text = "Title:    " + "\r\nSong:  " + "\r\nMode | Mod:    " + "\r\nBeatmap:    " + "\r\nPlayer Profile:    " + line;
        }
        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModeBox.Text))
            {
                ModeBox.Text = "";
                TitleBox.Text = "osu!" + SongBox.Text;
                SourceBox.Text = title + TitleBox.Text + song + SongBox.Text + mode + ModeBox.Text + beatmap + BeatmapBox.Text + profile + PlayerBox.Text + line + EtcBox.Text;
            }
            else
            {
                TitleBox.Text = "osu!" + SongBox.Text + " [" + ModeBox.Text + "]";
                SourceBox.Text = title + TitleBox.Text + song + SongBox.Text + mode + ModeBox.Text + beatmap + BeatmapBox.Text + profile + PlayerBox.Text + line + EtcBox.Text;
            }
        }
        private void SongBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SongBox.Text))
            {
                SongBox.Text = "";
                TitleBox.Text = "osu!";
            }
            else
            {
                TitleBox.Text = "osu!" + SongBox.Text;
            }
        }
        private void ModeBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModeBox.Text))
            {
                ModeBox.Text = "";
                TitleBox.Text = "osu!" + SongBox.Text;
            }
            else
            {
                TitleBox.Text = "osu!" + SongBox.Text + " [" + ModeBox.Text + "]";
            }
        }
        private void BeatmapBox_TextChanged(object sender, EventArgs e)
        {
            SourceBox.Text = title + TitleBox.Text + song + SongBox.Text + mode + ModeBox.Text + beatmap + BeatmapBox.Text + profile + PlayerBox.Text + line + EtcBox.Text;
        }
        private void PlayerBox_TextChanged(object sender, EventArgs e)
        {
            SourceBox.Text = title + TitleBox.Text + song + SongBox.Text + mode + ModeBox.Text + beatmap + BeatmapBox.Text + profile + PlayerBox.Text + line + EtcBox.Text;
        }
        private void EtcBox_TextChanged(object sender, EventArgs e)
        {
            SourceBox.Text = title + TitleBox.Text + song + SongBox.Text + mode + ModeBox.Text + beatmap + BeatmapBox.Text + profile + PlayerBox.Text + line + EtcBox.Text;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Title = TitleBox.Text;
            Settings.Default.Song = SongBox.Text;
            Settings.Default.mode_mods = ModeBox.Text;
            Settings.Default.beatmap = BeatmapBox.Text;
            Settings.Default.player_profile = PlayerBox.Text;
            Settings.Default.description = EtcBox.Text;
            Settings.Default.Save();
        }
        private void SaveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                FileName = "osu!" + SongBox.Text + ".txt",
                Filter = "Text File | *.txt"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(SourceBox.Text.ToString());
                writer.Dispose();
            }
        }
        private void ResetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Title = TitleBox.Text;
            Settings.Default.Song = SongBox.Text;
            Settings.Default.mode_mods = ModeBox.Text;
            Settings.Default.beatmap = BeatmapBox.Text;
            Settings.Default.player_profile = PlayerBox.Text;
            Settings.Default.description = EtcBox.Text;
            Settings.Default.Save();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TitleBox.Text = Settings.Default.Title;
            SongBox.Text = Settings.Default.Song;
            ModeBox.Text = Settings.Default.mode_mods;
            BeatmapBox.Text = Settings.Default.beatmap;
            PlayerBox.Text = Settings.Default.player_profile;
            EtcBox.Text = Settings.Default.description;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Title = TitleBox.Text;
            Settings.Default.Song = SongBox.Text;
            Settings.Default.mode_mods = ModeBox.Text;
            Settings.Default.beatmap = BeatmapBox.Text;
            Settings.Default.player_profile = PlayerBox.Text;
            Settings.Default.description = EtcBox.Text;
            Settings.Default.Save();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            SongBox.Text = "";
            ModeBox.Text = "";
            BeatmapBox.Text = "";
            PlayerBox.Text = "";
            EtcBox.Text = "";
        }
    }
}
