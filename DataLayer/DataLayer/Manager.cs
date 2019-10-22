using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataLayer
{
    public class Manager
    {
        public static object loadFile(string FileName)
        {
            object temp = null;
            try {
                if (File.Exists("..\\..\\..\\Storage\\" + FileName))
                {
                    Stream openFileStream = File.OpenRead("..\\..\\..\\Storage\\" + FileName);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    temp = deserializer.Deserialize(openFileStream);
                    openFileStream.Close();
                    return temp;
                }
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
                Stream SaveFileStream = File.Create("..\\..\\..\\Storage\\" + FileName);
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
