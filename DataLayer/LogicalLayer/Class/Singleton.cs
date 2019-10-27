using System;
using DataLayer;
using LogicalLayer.Enums;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogicalLayer
{

    public class Singleton
    {
        private const string PATH = "Currency\\";
        private const string TYPE = ".json";

        private static Singleton instance;
        private List<Money> money;

        private Currency currency;


        private Singleton()
        {
            
        }

        private List<Money> getData()
        {
            string data = Manager.loadJson(PATH + this.currency.ToString() + TYPE);

            if (data != null)
                return this.money = JsonConvert.DeserializeObject<List<Money>>(data);
            return this.money = new List<Money>();
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                return instance = new Singleton();
            }
            return instance;
        }


        public List<Money> getMoney()
        {
            return this.money;
        }

        public bool saveMoney()
        {
            string path = PATH + this.currency.ToString() + TYPE;
            Console.WriteLine(path);
            return Manager.saveJson(path,this.money);
        }

        public Currency getCurrency()
        {
            return this.currency;
        }
        public void setCurrency(Currency currency)
        {
            this.currency = currency;
            this.getData();
        }
       

        

    }
}
