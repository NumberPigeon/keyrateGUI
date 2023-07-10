using System;
using System.IO;

namespace KeyRateGUI
{
    internal class ConfigController
    {
        static string configPath = "config.ini";
        static uint delayMSec = 150;
        static uint repeatMSec = 10;
        static bool autoSave = false;

        public static void LoadConfig()
        {
            try
            {
                if (File.Exists(configPath))
                {
                    string[] lines = File.ReadAllLines(configPath);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith(";"))
                        {
                            string[] parts = line.Split('=');
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();

                                switch (key.ToLower())
                                {
                                    case "delay":
                                        if (uint.TryParse(value, out uint delay))
                                        {
                                            if (delay >= 0 && delay <= 9999)
                                            {
                                                delayMSec = delay;
                                            }
                                            else
                                            {
                                                delayMSec = 150; // 非法值设为默认值
                                            }
                                        }
                                        else
                                        {
                                            delayMSec = 150; // 解析失败，设为默认值
                                        }
                                        break;

                                    case "repeat":
                                        if (uint.TryParse(value, out uint repeat))
                                        {
                                            if (repeat >= 0 && repeat <= 9999)
                                            {
                                                repeatMSec = repeat;
                                            }
                                            else
                                            {
                                                repeatMSec = 10; // 非法值设为默认值
                                            }
                                        }
                                        else
                                        {
                                            repeatMSec = 10; // 解析失败，设为默认值
                                        }
                                        break;

                                    case "autosave":
                                        if (bool.TryParse(value, out bool autosave))
                                        {
                                            autoSave = autosave;
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    CreateDefaultConfig();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("解析配置文件时发生错误: " + ex.Message);
                CreateDefaultConfig();
            }
        }

        public static void SaveConfig()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configPath))
                {
                    writer.WriteLine("delay = " + delayMSec);
                    writer.WriteLine("repeat = " + repeatMSec);
                    writer.WriteLine("autosave = " + autoSave.ToString());
                }

                Console.WriteLine("配置已保存至 " + configPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("保存配置文件时发生错误: " + ex.Message);
            }
        }

        private static void CreateDefaultConfig()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configPath))
                {
                    writer.WriteLine("delay = " + delayMSec);
                    writer.WriteLine("repeat = " + repeatMSec);
                    writer.WriteLine("autosave = " + autoSave.ToString());
                }

                Console.WriteLine("已创建新的配置文件并设置了默认值。");
            }
            catch (Exception ex)
            {
                Console.WriteLine("创建默认配置文件时发生错误: " + ex.Message);
            }
        }

        public static uint DelayMSec
        {
            get { return delayMSec; }
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    delayMSec = value;
                }
                else
                {
                    delayMSec = 150; // 将非法值设为默认值
                }
            }
        }

        public static uint RepeatMSec
        {
            get { return repeatMSec; }
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    repeatMSec = value;
                }
                else
                {
                    repeatMSec = 10; // 将非法值设为默认值
                }
            }
        }

        public static bool AutoSave
        {
            get { return autoSave; }
            set { autoSave = value; }
        }
    }
}