using LogicalLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer
{
    public class Money
    {
        public float Value { get; set; }
        public Currency Currency { get; set; }
        public TypeCurrency TypeCurrency { get; set; }


        public Money(float value, TypeCurrency typeCurrency, Currency currency)
        {
            this.Currency = currency;
            this.TypeCurrency = typeCurrency;
            this.Value = value;

        }


    }
}
