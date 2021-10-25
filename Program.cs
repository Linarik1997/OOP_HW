using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(Definition.Current);
            account.GetInfo();
            Account account1 = new Account(5000);
            account1.GetInfo();
            Account account2 = new Account(Definition.Budget,10000);
            account2.GetInfo();
            account2.Deposit(2000);
            account2.Withdrawl(3000);
            account.Withdrawl(1000);
            account.GetInfo();
            Console.ReadLine();
        }
    }
}
