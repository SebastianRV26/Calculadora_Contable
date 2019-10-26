﻿using LogicalLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    public interface MoneyManager
    {
        void editCurrency(Money money);
        void deleteCurrency(Money money);
    }
}
