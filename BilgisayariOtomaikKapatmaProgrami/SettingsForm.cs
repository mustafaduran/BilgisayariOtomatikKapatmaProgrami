using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayariOtomatikKapatmaProgrami
{
    public partial class SettingsForm : Form
    {
        //public string[] waw = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\waw");
        public string[] waw_ = Directory.GetFiles("waw");
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (var item in waw_)
            {
                alarmCmbBox.Items.Add(item);
            }
            languageCmbBox.Text = BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.Language;
            alarmCmbBox.SelectedItem=Properties.Settings.Default.SelectedAlarm;
            Program.Lang.Apply(this);
        }
        public void SettingsLangReload()
        {
            Program.Lang.Apply(this);
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(alarmCmbBox.Text);
            player.Play();
            MessageBox.Show("Durdurmak için Tamam tuşuna basın.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            player.Stop();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.SelectedAlarm = alarmCmbBox.Text;
            BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.Language = languageCmbBox.Text;
            BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.Save();
            ((MainForm)Application.OpenForms["MainForm"])?.MainLangReload();
            ((SettingsForm)Application.OpenForms["SettingsForm"])?.SettingsLangReload();

        }
    }
}
