﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        //public double ServiceCharge { get; set; }
        //public double InterestAmount { get; set; }
        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
           
        public string Withdraw(double amount)
        {
                Balance -= amount;
                return "Withdraw";
        }
    }
}
