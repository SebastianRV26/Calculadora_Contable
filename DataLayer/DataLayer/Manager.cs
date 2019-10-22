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

        public static object loadFile(string FileName)
        {
            object temp = null;
            string path = PATH + FileName;
            try {
                if (File.Exists(path))
                {
                    Stream openFileStream = File.OpenRead(path);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    temp = deserializer.Deserialize(openFileStream);
                    openFileStream.Close();
                    return temp;
                }
                File.Create(path);
            }
            catch(Exception e)
            {
                Console.WriteLine("Load file error!");
                return temp;
            }
            return temp;

        }

        public static bool saveFile(string FileName, object data)
        {
            try {
                Stream SaveFileStream = File.Create(PATH + FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, data);
                SaveFileStream.Close();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

    }
}
