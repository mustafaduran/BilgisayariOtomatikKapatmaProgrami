using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayariOtomatikKapatmaProgrami
{
    internal partial class LanguageClass
    {
        internal static class DictionaryList
        {

            public static readonly Dictionary<string, string> MainForm_TR = new Dictionary<string, string>()
            {
                {"selectTimeGB","Süre Ayarlar"},
                {"selectModeGB","Mod Seç"},
                {"countDownGB","Geri Sayım"},
                {"shutdownBtn","Kapat"},
                {"restartBtn","Yeniden Başlat"},
                {"sleepBtn","Uyku"},
                {"singoutBtn","Oturumu Kapat"},
                {"lockBtn","Oturumu Kilitle"},
                {"alarmBtn","Alarm"},
                {"dayLbl","Gün"},
                {"hourLbl","Saat"},
                {"minuteLbl","Dakika"},
                {"secondLbl" ,"Saniye" },
            };

            public static readonly Dictionary<string, string> MainForm_EN = new Dictionary<string, string>()
            {
                {"selectTimeGB","Set Time"},
                {"selectModeGB","Select Mode"},
                {"countDownGB","Countdown"},
                {"shutdownBtn","Shutdown"},
                {"restartBtn","Restart"},
                {"sleepBtn","Sleep"},
                {"singoutBtn","Singout"},
                {"lockBtn","Lock"},
                {"alarmBtn","Alarm"},
                {"dayLbl","Day"},
                {"hourLbl","Hour"},
                {"minuteLbl","Minute"},
                {"secondLbl" ,"Second" },
            };
            public static readonly Dictionary<string, string> MainForm_DE = new Dictionary<string, string>()
            {
                {"selectTimeGB","Stelle einen timer"},
                {"selectModeGB","Modusauswahl"},
                {"countDownGB","Countdown"},
                {"shutdownBtn","Schließen"},
                {"restartBtn","Neustart"},
                {"sleepBtn","Schlafen"},
                {"singoutBtn","Abmelden"},
                {"lockBtn","Sperren"},
                {"alarmBtn","Alarm"},
                {"dayLbl","Tag"},
                {"hourLbl","Stunde"},
                {"minuteLbl","Minute"},
                {"secondLbl" ,"Zweite" },
            };

            public static readonly Dictionary<string, string> Settings_TR = new Dictionary<string, string>()
            {
                {"languageGB","Dil Seç" },
                {"alarmGB","Alarm" },
                {"saveBtn","Kaydet" },
            };

            public static readonly Dictionary<string, string> Settings_EN = new Dictionary<string, string>()
            {
                {"languageGB","Select Language" },
                {"alarmGB","Alarm" },
                {"saveBtn","Save" },
            };

            public static readonly Dictionary<string, string> Settings_DE = new Dictionary<string, string>()
            {
                {"languageGB","Sprachauswahl" },
                {"alarmGB","Alarm" },
                {"saveBtn","Speichern" },
            };

            public static readonly Dictionary<string, string> statusLbl_TR = new Dictionary<string, string>()
            {
                {MainForm.Mode.Shutdown.ToString(),"Kapatma modu akttif." },
                {MainForm.Mode.Restart.ToString(),"Yeniden başlatma modu akttif." },
                {MainForm.Mode.Sleep.ToString(),"Uyku modu akttif." },
                {MainForm.Mode.Singout.ToString(),"Oturum kapatma modu akttif." },
                {MainForm.Mode.Locked.ToString(),"Oturum kilitleme modu akttif." },
                {MainForm.Mode.Alarm.ToString(),"Alarm modu modu akttif." },
            };

            public static readonly Dictionary<string, string> statusLbl_EN = new Dictionary<string, string>()
            {
                {MainForm.Mode.Shutdown.ToString(),"Shutdown mode active."},
                {MainForm.Mode.Restart.ToString(),"Restart mode active."},
                {MainForm.Mode.Sleep.ToString(),"Sleep mode active."},
                {MainForm.Mode.Singout.ToString(),"Log off mode active."},
                {MainForm.Mode.Locked.ToString(),"Lock session mode active."},
                {MainForm.Mode.Alarm.ToString(),"Alarm mode active."},
            };

            public static readonly Dictionary<string, string> statusLbl_DE = new Dictionary<string, string>()
            {
                {MainForm.Mode.Shutdown.ToString(),"Herunterfahren-Modus aktiv."},
                {MainForm.Mode.Restart.ToString(),"Neustart-Modus aktiv."},
                {MainForm.Mode.Sleep.ToString(),"Schlafmodus aktiv."},
                {MainForm.Mode.Singout.ToString(),"Abmeldemodus aktiv."},
                {MainForm.Mode.Locked.ToString(),"Sitzungssperrmodus aktiv."},
                {MainForm.Mode.Alarm.ToString(),"Alarmmodus aktiv."},
            };

            public static readonly Dictionary<string, string> modeStatus = new Dictionary<string, string>()
            {
                {"TR_Stop","Mod durduruldu." },
                {"TR_Cancel","Mod iptal edildi." },
                {"EN_Stop","Mode stopped." },
                {"EN_Cancel","Mode canceled." },
                {"DE_Stop","Modus gestopptd." },
                {"DE_Cancel","Modus abgesagt." },
            };
        }

    }
}

