﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Credit_Cards
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
