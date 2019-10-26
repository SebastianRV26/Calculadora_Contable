using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataLayer
{
    public class Manager
    {
        private const string PATH = "..\\..\\..\\Storage\\";

        public static string loadJson(string FileName)
        {
            string path = PATH + FileName;
            try {
                if (File.Exists(path))
                {
                    string data = System.IO.File.ReadAllText(path);
                    if (data.Trim() == "")
                        return null;
                    else
                        return data;
                }
                File.Create(path);
            }
            catch(Exception e)
            {
                Console.WriteLine("Load file error!");
                
            }
            return null;

        }

        public static bool saveJson(string FileName, object data)
        {
            try {

                string json = JsonConvert.SerializeObject(data);
                System.IO.File.WriteAllText(PATH+FileName, json);
                Console.WriteLine("Save");
                return true;
            }
            catch (Exception e) {
                Console.WriteLine("Save Error");
                return false;
            }
        }

    }
}
