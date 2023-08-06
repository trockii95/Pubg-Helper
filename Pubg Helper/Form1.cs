using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelperLooT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button10_Click(object sender, EventArgs e)
        {
            //shutdown /l
            cmds.ExecuteCommand("shutdown /l");
        }
        
        IniFile iniFile;
        Dictionary<string, string> settings;
        string defTime;
        string defLang;
        string defCnKeyb;
        private void Form1_Load(object sender, EventArgs e)
        {
            //загрузка ini
            string fileName = "settings.ini";
            iniFile = new IniFile(fileName);
            settings = iniFile.ReadSettings();
            defTime = settings["TimeDef"];
            defLang = settings["LangDef"];
            defCnKeyb = settings["CnKeyboard"];

            //Настройка удаления раскладки
            if (defCnKeyb == "yes")
            {

                radio_da.Checked = true;
            }
            else if(defCnKeyb == "no") {
                radio_net.Checked = true;
            }
            

            //Настройка языка системы
            //comboBox_defLang
            comboBox_defLang.SelectedIndex = comboBox_defLang.FindStringExact(defLang);

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var l in timeZones) {
                string utc_raw = l.DisplayName.ToString();
                //string input = "(UTC+00:00) 圣多美";
                string pattern = @"\(.+?\)";
                string result = "";
                Match match = Regex.Match(utc_raw, pattern);
                if (match.Success)
                {
                    result = match.Value;
                    Console.WriteLine(result); // Выводит: (UTC+00:00)
                }
                string id = l.Id.ToString();
                if (id == "UTC") { }
                else
                {
                    string utc = result + " " + id;

                    comboBox_defTimezone.Items.Add(utc);
                }

            }
            //Настройка тайм зоны
            //comboBox_defTimezone
            comboBox_defTimezone.SelectedIndex = comboBox_defTimezone.FindStringExact(defTime);

        }


        private void comboBox_defTimezone_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox_defTimezone.SelectedItem.ToString();
            iniFile.UpdateSetting("TimeDef", s);
        }

        private void comboBox_defLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox_defLang.SelectedItem.ToString();
            iniFile.UpdateSetting("LangDef", s);
        }

        private void radio_da_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_da.Checked==true) {
                iniFile.UpdateSetting("CnKeyboard", "yes");
            }
            
        }

        private void radio_net_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_net.Checked == true)
            {
                iniFile.UpdateSetting("CnKeyboard", "no");
            }
        }

        private void button_defSett_Click(object sender, EventArgs e)
        {
            //часовой пояс
            string tz = RemoveFirstCharacters(comboBox_defTimezone.SelectedItem.ToString(),12);
            cmds.ExecuteCommand("tzutil /s "+tz);

            //язык системы
            string lng = comboBox_defLang.SelectedItem.ToString();
            cmds.ExecutePowerShellCommand("Set-WinUILanguageOverride "+lng);

            //удаление раскладки
            if (radio_da.Checked == true) {
                string script = @"
$LanguageList = Get-WinUserLanguageList
$DeleteLang = $LanguageList | where LanguageTag -eq 'zh-Hans-CN'
$LanguageList.Remove($DeleteLang)
Set-WinUserLanguageList $LanguageList -Force
";
                cmds.ExecutePowerShellScript(script);

            }
        }
        static string RemoveFirstCharacters(string input, int count)
        {
            if (input.Length <= count)
            {
                return string.Empty;
            }

            return input.Substring(count);
        }

        private void button_reboot_Click(object sender, EventArgs e)
        {
            //reboot
            cmds.ExecutePowerShellScript("Restart-Computer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmds.ExecuteCommand("tzutil /s \"China Standard Time\"");
            cmds.ExecutePowerShellCommand("Set-WinUILanguageOverride zh-CN");
            string script = @"
$list = Get-WinUserLanguageList
$list.Add('zh-Hans-CN')
Set-WinUserLanguageList $list -Force";
            cmds.ExecutePowerShellScript(script);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(UTC+03:00) Russian Standard Time
            cmds.ExecuteCommand("tzutil /s \"Russian Standard Time\"");
            cmds.ExecutePowerShellCommand("Set-WinUILanguageOverride ru-RU");
            string script = @"
$LanguageList = Get-WinUserLanguageList
$DeleteLang = $LanguageList | where LanguageTag -eq 'zh-Hans-CN'
$LanguageList.Remove($DeleteLang)
Set-WinUserLanguageList $LanguageList -Force
";
            cmds.ExecutePowerShellScript(script);
        }

        private void button_installCN_Click(object sender, EventArgs e)
        {
            //Install-Language -Language zh-cn -ExcludeFeatures
            cmds.PubExecutePowerShellCommand("Install-Language -Language zh-cn -ExcludeFeatures");
        }

        private void button_deinstallCN_Click(object sender, EventArgs e)
        {
            //Uninstall-Language -Language zh-cn
            cmds.PubExecutePowerShellCommand("Uninstall-Language -Language zh-cn");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ibakhmetnews");
        }

        private void button6_Click(object sender, EventArgs e)
        {
        //
        
            System.Diagnostics.Process.Start("https://github.com/trockii95/Helper-Helper/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/ibakhmet");
        }
    }
}
