using System;
using System.Text;
using DataLayer;
using Newtonsoft.Json.Linq;

namespace LogicalLayer
{
    public class Singleton
    {
        private static Singleton instance;

        private JArray dollars;
        private JArray colones;


        private Singleton(JArray dollars, JArray colones)
        {
            this.dollars = dollars;
            this.colones = colones;
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                SingletonManager manager = new SingletonManager("Money.json");
                return instance = new Singleton(manager.dollars, manager.colones);
            }
            return instance;
        }

        public JArray getDollars()
        {
            return this.dollars;
        }

        public JArray getColones()
        {
            return this.colones;
        }



    }
}
