﻿using System;
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
        private const string CURRENCY = "Currency\\";
        private static Singleton instance;
        private List<Money> money;
        private Currency target;


        private Singleton(Currency target)
        {
            this.target = target;
            string path = CURRENCY + target + ".dat";

            this.money = (List<Money>) Manager.loadFile(path);

            if(this.money is null)
            {
                this.money = new List<Money>();

                this.money.Add(new Money(1000, TypeCurrency.Bill, Currency.Colones));
                this.money.Add(new Money(1000, TypeCurrency.Coin, Currency.Colones));
            }
            
        }

        public static Singleton getInstance(Currency currency)
        {
            if (instance == null)
            {
                return instance = new Singleton(currency);
            }
            return instance;
        }

        public List<Money> getMoney()
        {
            return this.money;
        }

        public bool saveMoney()
        {
            string path = CURRENCY + this.target + ".dat";
            return Manager.saveFile(path,this.money);
        }

 


    }
}
