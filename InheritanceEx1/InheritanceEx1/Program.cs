using InheritanceEx1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount();
            sa.InterestAmount = 500;
            sa.AccountNo = "sv-001";
            sa.CustomerName = "Md Moazz";
            sa.Deposit(amount: 1000);
            sa.Withdraw(amount: 500);
            double balance = sa.Balance;


            CheckingAccount ca = new CheckingAccount();
            ca.ServiceCharge = 1000;
            ca.AccountNo = "Ch-002";
            ca.CustomerName = "Noman";
            ca.Deposit(amount: 2000);
            ca.Withdraw(amount: 300);

            balance = ca.Balance;

            //BankAccount ba = new BankAccount();


        }
    }
}
