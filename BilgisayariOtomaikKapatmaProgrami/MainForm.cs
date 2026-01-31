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

        
        public void MainLangReload()
        {
            Program.Lang.Apply(this);
        }
        public MainForm()
        {
            InitializeComponent();
            shutdownBtn.Tag = Mode.Shutdown;
            restartBtn.Tag = Mode.Restart;
            sleepBtn.Tag = Mode.Sleep;
            singoutBtn.Tag = Mode.Singout;
            lockBtn.Tag = Mode.Locked;
            alarmBtn.Tag = Mode.Alarm;
            statusLbl.Text = "";
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
            //statusLbl.Text=selectedMod+" modu aktif";
            statusLbl.Text = LanguageClass.GetModeText(selectedMod.ToString());
            statusLbl.ForeColor = Color.Green;
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
            
            selectedMod = (Mode)shutdownBtn.Tag;
            GeneralScript();

        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            selectedMod = (Mode)restartBtn.Tag;
            GeneralScript();
        }

        private void sleep_btn_Click(object sender, EventArgs e)
        {
            selectedMod = (Mode)sleepBtn.Tag;
            GeneralScript();
        }

        private void singout_btn_Click(object sender, EventArgs e)
        {
            selectedMod = (Mode)singoutBtn.Tag;
            GeneralScript();
        }

        private void lock_btn_Click(object sender, EventArgs e)
        {
            selectedMod = (Mode)lockBtn.Tag;
            GeneralScript();
        }

        private void alarm_btn_Click(object sender, EventArgs e)
        {
            selectedMod = (Mode)alarmBtn.Tag;
            GeneralScript();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            int day = selectedTime / 86400;
            int hour = (selectedTime % 86400) / 3600;
            int minute = (selectedTime % 3600) / 60;
            int second = selectedTime % 60;

            time_lbl.Text = $"{day}g {hour:D2}:{minute:D2}:{second:D2}";

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
                statusLbl.Text = LanguageClass.ModeStatusText(true);
                statusLbl.ForeColor = Color.Gray;
            }
            else
            {
                timer1.Start();
                stop_start_btn.Text = "⏸";
                statusLbl.Text = LanguageClass.GetModeText(selectedMod.ToString());
                statusLbl.ForeColor = Color.Green;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
           
            statusLbl.Text = LanguageClass.ModeStatusText(false);
            statusLbl.ForeColor = Color.Red;
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
