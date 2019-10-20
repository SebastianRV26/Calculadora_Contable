using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataLayer
{
    class Manager
    {
        public static string loadFile(string filename)
        {
            try { 
                return System.IO.File.ReadAllText("..\\..\\..\\Storage\\" + filename);
            }catch(Exception e)
            {
                return "";
            }
        }

        public static bool saveFile(string filename,string data)
        {
            try { 
                StreamWriter sw = new StreamWriter("..\\..\\..\\Storage\\" + filename, false, Encoding.ASCII);
                sw.Write(data);
                sw.Close();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

    }
}
