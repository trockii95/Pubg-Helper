using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelperLooT
{
    public static class cmds
    {

        public static void ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    Console.WriteLine("Результат выполнения команды:");
                    Console.WriteLine(output);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
        public static void ExecutePowerShellCommand(string command)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    Console.WriteLine("Результат выполнения команды PowerShell:");
                    Console.WriteLine(output);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
        public static void PubExecutePowerShellCommand(string command)
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    //CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    Console.WriteLine("Результат выполнения команды PowerShell:");
                    Console.WriteLine(output);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        public static void ExecutePowerShellScript(string s)
        {

            string powerShellPath = "powershell.exe";

            // Параметры запуска PowerShell (передаем скрипт в качестве аргумента командной строки)
            string arguments = $"-ExecutionPolicy Bypass -NoLogo -NoProfile -Command \"{s}\"";

            // Создаем процесс для выполнения скрипта PowerShell
            ProcessStartInfo psi = new ProcessStartInfo(powerShellPath, arguments)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process ps = new Process())
            {
                ps.StartInfo = psi;

                // Запускаем процесс PowerShell
                ps.Start();

                // Читаем вывод скрипта
                string output = ps.StandardOutput.ReadToEnd();
                string errorOutput = ps.StandardError.ReadToEnd();

                // Ожидаем завершения процесса
                ps.WaitForExit();

                // Выводим результаты
                Console.WriteLine("Результат выполнения:");
                Console.WriteLine(output);


            }
        }


    }
}
