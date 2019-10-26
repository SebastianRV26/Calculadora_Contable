using System;
using System.Text;
using DataLayer;
using LogicalLayer.Enums;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;

namespace LogicalLayer
{

    public class Singleton
    {
        private const string PATH = "Currency\\";
        private static Singleton instance;
        private List<Money> money;
        private Currency currency;


        private Singleton(Currency target)
        {
            this.currency = target;
            string data = Manager.loadJson(PATH + target.ToString() + ".json");
            Console.WriteLine(data);
            if (data != null)
                this.money = JsonConvert.DeserializeObject<List<Money>>(data);
            else
                this.money = new List<Money>();   
        }

        public static Singleton getInstance(Currency currency)
        {
            if (instance == null)
            {
                return instance = new Singleton(currency);
            }
            return instance;
        }

        public static Singleton getInstance()
        {
            return instance;
        }


        public List<Money> getMoney()
        {
            return this.money;
        }

        public bool saveMoney()
        {
            string path = PATH + this.currency.ToString() + ".json";
            Console.WriteLine(path);
            return Manager.saveJson(path,this.money);
        }

        public Currency getCurrency()
        {
            return this.currency;
        }

 


    }
}
