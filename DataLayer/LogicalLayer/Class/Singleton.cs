using System;
using System.Text;
using DataLayer;
using LogicalLayer.Enums;
using System.Collections.Generic;
using System.Collections;


namespace LogicalLayer
{
    [Serializable]
    public class Singleton
    {
        private const string FILENAME = "data.dat";
        private static Singleton instance;
        private Hashtable money;


        private Singleton()
        {
            this.money = new Hashtable();

            // Datos Quemados
            foreach (Currency currency in Enum.GetValues( typeof(Currency)))
            {
                this.money.Add(currency, new List<Money>());
            }

            
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = (Singleton)Manager.loadFile(FILENAME);
                return instance == null ? instance = new Singleton() : instance;
            }
            return instance;
        }

        public Hashtable getMoney()
        {
            return this.money;
        }

        public bool saveSingleton()
        {
            return Manager.saveFile(FILENAME, this);
        }


    }
}
