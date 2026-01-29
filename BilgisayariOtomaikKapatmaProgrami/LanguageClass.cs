using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayariOtomatikKapatmaProgrami
{
    internal partial class LanguageClass
    {

        public Dictionary<string,string> getMainForm_TR { get; private set; }
        public Dictionary<string,string> getMainForm_EN { get; private set; }
        public Dictionary<string,string> getMainForm_DE { get; private set; }

        public Dictionary<string,string> getSettingForm_TR { get; private set; }
        public Dictionary<string,string> getSettingForm_EN { get; private set; }
        public Dictionary<string,string> getSettingForm_DE { get; private set; }
        public LanguageClass()
        {
            getMainForm_TR = DictionaryList.MainForm_TR;
            getMainForm_EN = DictionaryList.MainForm_EN;
            getMainForm_DE = DictionaryList.MainForm_DE;

            getSettingForm_TR= DictionaryList.Settings_TR;
            getSettingForm_EN= DictionaryList.Settings_EN;
            getSettingForm_DE= DictionaryList.Settings_DE;

        }
        public void Apply(Form form)
        {
            string language=BilgisayariOtomatikKapatmaProgrami.Properties.Settings.Default.Language;
            Dictionary<string, string> data = new Dictionary<string, string>();
            string formName = form.Name;

            if (language == "TR")
            {
                if (formName == "MainForm") { data = getMainForm_TR; }
                if (formName == "SettingsForm") { data = getSettingForm_TR; }
            }

            if (language == "EN")
            {
                if (formName == "MainForm") { data = getMainForm_EN; }
                if (formName == "SettingsForm") { data = getSettingForm_EN; }
            }

            if (language == "DE")
            {
                if (formName == "MainForm") { data = getMainForm_DE; }
                if (formName == "SettingsForm") { data = getSettingForm_DE; }
            }

            foreach (Control ctrl in form.Controls)
            {
                foreach (var item  in data)
                {
                    if (item.Key == ctrl.Name)
                    {
                        ctrl.Text=item.Value;
                    }
                    if (ctrl is GroupBox)
                    {
                        foreach (Control ctrl2 in ctrl.Controls)
                        {
                           if (item.Key == ctrl2.Name)
                           {
                               ctrl2.Text = item.Value;
                           }
                        }
                    }
                }
            }
        }
    }

}
