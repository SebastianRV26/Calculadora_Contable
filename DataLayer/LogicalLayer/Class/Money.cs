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

        private int Quantity { get; set; }
        
        public Money(float value, TypeCurrency typeCurrency, Currency currency)
        {
            this.Currency = currency;
            this.TypeCurrency = typeCurrency;
            this.Value = value;
            this.Quantity = 0;

        }

        public int getQuantity()
        {
            return this.Quantity;
        }

        public void setQuantity(int quantity)
        {
            this.Quantity += quantity;
        }
    }
}
