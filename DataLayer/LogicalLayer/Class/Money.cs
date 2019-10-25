using LogicalLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer
{
    [Serializable]
    public class Money
    {
        private float Value { get; set; }
        private Currency currency { get; set; }
        private TypeCurrency typeCurrency { get; set; }
        private String photoPath { get; set; }

        public Money(float value, TypeCurrency typeCurrency, Currency currency)
        {
            this.currency = currency;
            this.typeCurrency = typeCurrency;
            this.Value = value;

        }

        public Money(float value, TypeCurrency typeCurrency, Currency currency,string photoPath)
        {
            this.currency = currency;
            this.typeCurrency = typeCurrency;
            this.Value = value;
            this.photoPath = photoPath;
        }

        public TypeCurrency GetTypeCurrency()
        {
            return this.typeCurrency;
        }

        public float getValue()
        {
            return this.Value;
        }

        public void setValue(int newValue)
        {
            this.Value = newValue;
        }
    }
}
