using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace HDFCBankApp
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HDFC Bank........\n");
            Console.WriteLine("Enter Initial amount for Account Openning...");
            double initialBalance = double.Parse(Console.ReadLine());
            //Model
            //Step 5:
            Account acct123 = new Account(initialBalance);
            
            //Step 6:
            //setting the routing logic of operation handling  {Dispatcher)
            //registering event with event handler if infuture event get raised
  
            acct123.underBalance += new BankOperation(AccountContoller.BlockAccount);
            acct123.underBalance += AccountContoller.SendEmailNotification;

            Console.WriteLine("Enter  amount to withdraw from  Account");
            double amount = double.Parse(Console.ReadLine());

            //Step 6: Invoke Request funds transaction
            acct123.Withdraw(amount); // Invoking  Request

            Console.WriteLine("Your Balance = {0}", acct123.Balance);
            //HDFC BAnk Console--------View
            Console.ReadLine();
        }
    }
}
