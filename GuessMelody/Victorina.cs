using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool subfolders = false;

        static public void ReadMusic()
        {
            string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", subfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_files);
        }

        static string regKeyName = "Software\\K2nK1n\\GuessMelody";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("Random", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("Subfolders", subfolders);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("Random", false));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    subfolders = Convert.ToBoolean(rk.GetValue("Subfolders", false));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
