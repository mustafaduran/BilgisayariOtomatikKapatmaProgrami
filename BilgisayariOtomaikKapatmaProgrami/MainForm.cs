using System.Runtime.InteropServices;
using System.IO;
using System.Media;
using System.Windows.Forms.VisualStyles;
using BilgisayariOtomatikKapatmaProgrami;
using System.Runtime.InteropServices;

namespace BilgisayariOtomatikKapatmaProgrami
{

    public partial class MainForm : Form
    {
        public enum Mode
        {
            Shutdown,
            Restart,
            Sleep,
            Singout,
            Locked,
            Alarm,
            Any
        }
        public Mode selectedMod = Mode.Any;
        public int selectedTime = 0;

        public string[] waw = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\waw");
        public string[] waw_ = Directory.GetFiles( "waw");

        public void MainLangReload()
        {
            Program.Lang.Apply(this);
        }
        public MainForm()
        {
            InitializeComponent();
            shutdown_btn.Tag = Mode.Shutdown;
            restart_btn.Tag = Mode.Restart;
            sleep_btn.Tag = Mode.Sleep;
            singout_btn.Tag = Mode.Singout;
            lock_btn.Tag = Mode.Locked;
            alarm_btn.Tag = Mode.Alarm;
            MainLangReload();
        }
        public int getSelectSecond()
        {
            int day = (int)day_input.Value;
            int hour = (int)clock_input.Value;
            int minute = (int)minute_input.Value;
            int second = (int)second_input.Value;

            var totalsecond = (day * 60 * 60 * 24) + (hour * 60 * 60) + (minute * 60) + second;

            return totalsecond;
        }
        public void GeneralScript()
        {
            selectedTime = getSelectSecond();
            progressBar.Value = 0;
            progressBar.Maximum = selectedTime;
            timer1.Start();
            selectTimeGB.Enabled = false;
            selectModeGB.Enabled = false;
            countDownGB.Enabled = true;
        }
        public void ResetScript()
        {
            selectTimeGB.Enabled = true;
            selectModeGB.Enabled = true;
            countDownGB.Enabled = false;
            timer1.Dispose();
            stop_start_btn.Text = "⏸";
            time_lbl.Text = "0g 00:00:00";
            selectedMod = Mode.Any;
            progressBar.Value = 0;
        }
        #region Mode Button
        private void shutdown_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)shutdown_btn.Tag;

        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)restart_btn.Tag;
        }

        private void sleep_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)sleep_btn.Tag;
        }

        private void singout_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)singout_btn.Tag;
        }

        private void lock_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)lock_btn.Tag;
        }

        private void alarm_btn_Click(object sender, EventArgs e)
        {
            GeneralScript();
            selectedMod = (Mode)alarm_btn.Tag;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            int gun = selectedTime / 86400;
            int saat = (selectedTime % 86400) / 3600;
            int dakika = (selectedTime % 3600) / 60;
            int saniye = selectedTime % 60;

            time_lbl.Text = $"{gun}g {saat:D2}:{dakika:D2}:{saniye:D2}";

            if (selectedTime <= 0) ModeRun();
            else { selectedTime--; progressBar.Value++; }
        }

        public void ModeRun()
        {
            timer1.Stop();
            switch (selectedMod)
            {
                case Mode.Shutdown:
                    ShutdownMode();
                    break;

                case Mode.Restart:
                    RestartMode();
                    break;

                case Mode.Sleep:
                    SleepMode();
                    break;

                case Mode.Singout:
                    SingoutMode();
                    break;

                case Mode.Locked:
                    LockedMode();
                    break;

                case Mode.Alarm:
                    AlarmMode();
                    break;

            }
            ResetScript();
        }

        private void stop_start_btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                stop_start_btn.Text = "▶";
            }
            else
            {
                timer1.Start();
                stop_start_btn.Text = "⏸";
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ResetScript();
        }

        public void ShutdownMode()
        {
            System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
        }

        public void RestartMode()
        {
            System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
        }

        public void SleepMode()
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }

        public void SingoutMode()
        {
            System.Diagnostics.Process.Start("shutdown", "-l -f");
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();
        public void LockedMode()
        {
            LockWorkStation();
        }


        public void AlarmMode()
        {
            SoundPlayer player = new SoundPlayer(BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.SelectedAlarm);
            player.PlayLooping();
            MessageBox.Show("Alarmı kapatmak için Tamam tuşuna basın.", "Alarmı Kapat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            player.Stop();
        }


       

        private void setting_btn_Click(object sender, EventArgs e)
        {
          SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

        }

       

       
    }
}
