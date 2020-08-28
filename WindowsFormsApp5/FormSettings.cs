using System;
using System.Configuration;

namespace WindowsFormsApp5
{
    //Application settings wrapper class
    sealed class FormSettings : ApplicationSettingsBase
    {
        [UserScopedSettingAttribute()]
        public String FormText
        {
            get { return (String)this["FormText"]; }
            set { this["FormText"] = value; }
        }
        protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
        {
            if (string.IsNullOrEmpty(FormText))
            {
                FormText = "override OnSettingsLoaded";
            }
        }
    }
}
