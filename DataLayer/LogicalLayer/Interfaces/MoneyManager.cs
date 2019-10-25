using LogicalLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    public interface MoneyManager
    {
        Boolean editMoney(int number, int newValue, TypeCurrency typeCurrency);
        Boolean deleteMoney(int value, TypeCurrency typeCurrency);
    }
}
