using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HelperLooT
{
    internal class IniFile
    {
        private string filePath;

        public IniFile(string fileName)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(exePath);
            filePath = Path.Combine(directory, fileName);
        }

        // Метод для чтения настроек из INI-файла
        public Dictionary<string, string> ReadSettings()
        {
            var settings = new Dictionary<string, string>();

            try
            {
                if (!File.Exists(filePath))
                {
                    CreateDefaultSettings();
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();
                            settings[key] = value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return settings;
        }

        // Метод для записи настроек в INI-файл
        public void SaveSettings(Dictionary<string, string> settings)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in settings)
                    {
                        writer.WriteLine($"{kvp.Key}={kvp.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        // Создание файла с дефолтными настройками
        private void CreateDefaultSettings()
        {
            Dictionary<string, string> defaultSettings = new Dictionary<string, string>();
            //(UTC+03:00) Russian Standard Time
            //(UTC+03:00) Russian Standard Time
            defaultSettings["TimeDef"] = "(UTC+03:00) Russian Standard Time";
            defaultSettings["LangDef"] = "en-US";
            defaultSettings["CnKeyboard"] = "yes";

            SaveSettings(defaultSettings);
        }

        // Обновление значения указанного ключа
        public void UpdateSetting(string key, string value)
        {
            Dictionary<string, string> settings = ReadSettings();
            settings[key] = value;
            SaveSettings(settings);
        }
    }
}
