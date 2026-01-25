using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayariOtomatikKapatmaProgrami
{
    internal class LanguageClass
    {
        public DataTable languageDT { get; private set; }
        //public static DataTable languageDT = new DataTable();
        public LanguageClass()
        {
            languageDT = new DataTable();
            if (!languageDT.Columns.Contains("FormName")) 
            { 
                languageDT.Columns.Add("FormName",typeof(string));
                languageDT.Columns.Add("Obj",typeof(string));
                languageDT.Columns.Add("TR",typeof(string));
                languageDT.Columns.Add("EN",typeof(string));
                languageDT.Columns.Add("DE",typeof(string));
            }

            languageDT.Rows.Add("MainForm","selectTimeGB","Süre Ayarlar","Set Time", "Stelle einen timer");
            languageDT.Rows.Add("MainForm","selectModeGB","Mod Seç","Select Mode", "Modusauswahl");
            languageDT.Rows.Add("MainForm","countDownGB","Geri Sayım","Countdown", "Countdown");
            languageDT.Rows.Add("MainForm","shutdown_btn","Kapat","Shutdown", "Schließen");
            languageDT.Rows.Add("MainForm","restart_btn","Yeniden Başlat","Restart", "Neustart");
            languageDT.Rows.Add("MainForm","sleep_btn","Uyku","Sleep", "Schlafen");
            languageDT.Rows.Add("MainForm","singout_btn","Oturumu Kapat","Singout", "Abmelden");
            languageDT.Rows.Add("MainForm","lock_btn","Oturumu Kilitle","Locked", "Sperren");
            languageDT.Rows.Add("MainForm","alarm_btn","Alarm","Alarm","Alarm");
            languageDT.Rows.Add("MainForm","dayLbl","Gün","Day","Tag");
            languageDT.Rows.Add("MainForm","hourLbl","Saat","Hours","Stunde");
            languageDT.Rows.Add("MainForm","minuteLbl","Dakika","Minute","Minute");
            languageDT.Rows.Add("MainForm","secondLbl" ,"Saniye","Seconds", "Zweite");

            languageDT.Rows.Add("SettingsForm", "languageGB", "Dil", "Language","Zunge");
            languageDT.Rows.Add("SettingsForm", "alarmGB", "Alarm", "Alarm","Alarm");
            languageDT.Rows.Add("SettingsForm", "saveBtn", "Kaydet", "Save", "Speichern");
        }





        public void Apply(Form form)
        {
            int language=BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.Language;
            foreach(Control ctrl in form.Controls)
            {
                string formName = form.Name;
               foreach(DataRow r in languageDT.Rows)
                {
                    if (r["FormName"] ==formName && r["Obj"]==ctrl.Name)
                    {
                        switch (language)
                        {
                            case 0:
                                ctrl.Text = r["TR"].ToString();
                                break;
                            case 1:
                                ctrl.Text = r["EN"].ToString();
                                break;
                            case 2:
                                ctrl.Text = r["DE"].ToString();
                                break;

                        }

                    }
                    if (ctrl is GroupBox)
                    {
                        foreach (Control ctrl2 in ctrl.Controls)
                        {
                            if (r["FormName"] == formName && r["Obj"] == ctrl2.Name)
                            {
                                switch (language)
                                {
                                    case 0:
                                        ctrl2.Text = r["TR"].ToString();
                                        break;
                                    case 1:
                                        ctrl2.Text = r["EN"].ToString();
                                        break;
                                    case 2:
                                        ctrl2.Text = r["DE"].ToString();
                                        break;

                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
