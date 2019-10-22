using System;
using System.Text;
using DataLayer;
using Newtonsoft.Json.Linq;
using LogicalLayer.Enums;
using System.Collections.Generic;
using System.Collections;

namespace LogicalLayer
{
    [Serializable]
    public class Singleton
    {
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

            
            for(byte i = 0; i < 5; i++)
            {
                ((List<Money>)money[Currency.Colones]).Add(new Money(i, TypeCurrency.Coin, Currency.Colones));
            }

            for (byte i = 0; i < 5; i++)
            {
                ((List<Money>)money[Currency.Colones]).Add(new Money(i, TypeCurrency.Coin, Currency.Dolllar));
            }

            for (byte i = 0; i < 5; i++)
            {
                ((List<Money>)money[Currency.Colones]).Add(new Money(1000+i, TypeCurrency.Bill, Currency.Colones));
            }

            for (byte i = 0; i < 5; i++)
            {
                ((List<Money>)money[Currency.Colones]).Add(new Money(10 + i, TypeCurrency.Bill, Currency.Dolllar));
            }

            // Datos Quemado, se van a borrar;
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                return instance = new Singleton();
            }
            return instance;
        }

        public Hashtable getMoney()
        {
            return this.money;
        }

    }
}
