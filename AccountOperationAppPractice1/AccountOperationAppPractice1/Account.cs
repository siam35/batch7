using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string AccountNumber;
        public string CustomerName;
        public int Balance;


        public int Deposit(int Amount)
        {
            Balance = Balance + Amount;

            return Balance;

        }

        public int Withdraw(int Amount)
        {
            Balance = Balance - Amount;
           
                return Balance;
            
           
        }

        public string GetReport()
        {
            return CustomerName + " ,your account number " + AccountNumber + " and it's balance: " + Balance + " Taka";
        }
    }


}
