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
            }

            languageDT.Rows.Add("MainForm","selectTimeGB","Süre Ayarlar","Set Time");
            languageDT.Rows.Add("MainForm","selectModeGB","İşlev Seç","Select Mode");
            languageDT.Rows.Add("MainForm","countDownGB","Geri Sayım","Countdown");
            languageDT.Rows.Add("MainForm","shutdown_btn","Kapat","Shutdown");
            languageDT.Rows.Add("MainForm","restart_btn","Yeniden Başlat","Restart");
            languageDT.Rows.Add("MainForm","sleep_btn","Uyku","Sleep");
            languageDT.Rows.Add("MainForm","singout_btn","Oturumu Kapat","Singout");
            languageDT.Rows.Add("MainForm","lock_btn","Oturumu Kilitle","Locked");
            languageDT.Rows.Add("MainForm","alarm_btn","Alarm","Alarm");
            languageDT.Rows.Add("MainForm","dayLbl","Gün","Day");
            languageDT.Rows.Add("MainForm","hourLbl","Saat","Hours");
            languageDT.Rows.Add("MainForm","minuteLbl","Dakika","Minute");
            languageDT.Rows.Add("MainForm","secondLbl" ,"Saniye","Seconds");

            languageDT.Rows.Add("SettingsForm", "languageGB", "Dil", "Language");
            languageDT.Rows.Add("SettingsForm", "alarmGB", "Alarm", "Alarm");
            languageDT.Rows.Add("SettingsForm", "saveBtn", "Kaydet", "Save");
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
                        ctrl.Text = (language == 0) ? r["TR"].ToString() : r["EN"].ToString();
                    }
                    if (ctrl is GroupBox)
                    {
                        foreach (Control ctrl2 in ctrl.Controls)
                        {
                            if (r["FormName"] == formName && r["Obj"] == ctrl2.Name)
                            {
                                ctrl2.Text = (language == 0) ? r["TR"].ToString() : r["EN"].ToString();
                            }
                        }
                    }
                }
            }
        }
    }

}
