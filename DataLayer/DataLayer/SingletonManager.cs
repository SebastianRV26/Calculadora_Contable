using System;
using System.Collections;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DataLayer
{
    public class SingletonManager
    {
        public JArray dollars { get; set; }
        public JArray colones { get; set; }

        public SingletonManager(string filename)
        {
            string data = Manager.loadFile(filename);

            if (!data.Equals("")) {
                JObject jObject = JObject.Parse(data);
                this.colones = (JArray) jObject["Colones"];
                this.dollars = (JArray) jObject["Dollars"];
                return;
            }

            this.colones = new JArray();
            this.dollars = new JArray();  

        }

        public static bool saveData(string filename,JArray colones, JArray dollars)
        {
            string data = "{'Colones':" + colones.ToString() + ",'Dollars':" + dollars.ToString( )+ "}";
            return Manager.saveFile(filename, data);
        }

        
    }
}
