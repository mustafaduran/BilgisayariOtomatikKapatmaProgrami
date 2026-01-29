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
        }

    }
}

