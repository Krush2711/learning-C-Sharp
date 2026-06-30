using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class BankAccount
    {
        public string AccountHolder;
        private double Balance; // nobody outside the class should modify the blance 
    public void Deposite(double amount)
        {
            if (amount < 0 )
            {
                Console.WriteLine("Enter the valid amount to deposite ");
                return; 
            }
            Balance = Balance + amount;
            Console.WriteLine("Amount Deposited.");
        }

    public void WithDraw(double amount)
        {
            if(Balance < amount || amount <  0)
            {
                Console.WriteLine("Balance is not enough !");
                return;
            }
            Balance = Balance - amount;
            Console.WriteLine("Amount withdraw successfully !");
        }

    public void CheckBalance()
        {
            Console.WriteLine($"Your balance is {Balance}");
        }
    }


    
}