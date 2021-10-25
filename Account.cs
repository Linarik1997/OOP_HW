using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{

    public enum Definition 
    {
        NotDefined,
        Credit,
        Current,
        Deposit,
        Budget,
        Payment
    };
    public enum WithdrawlErrors
    {
        Ok = 0,
        InsufficientFunds = 1,
        UnexpectedError = 2
    };
    class Account
    {
        #region private fields
        /// <summary>
        /// Account Number
        /// </summary>
        private long id;
        /// <summary>
        /// Type of account
        /// </summary>
        private Definition definition;
        /// <summary>
        /// Balance on the account
        /// </summary>
        private decimal balance;
        /// <summary>
        /// static value to generate unique id
        /// </summary>
        private static long idGenerate;
        #endregion
        #region Properties
        public long Id
        {
            get { return id; }
        }
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public Definition Define
        {
            get { return definition; }
            private set { definition = value; }
        }
        #endregion
        #region Constructors
        public Account()
        {
            OnCreateNewAccount();
            Define = Definition.NotDefined;
        }
        public Account(Definition _definition)
        {
            OnCreateNewAccount();
            Define = _definition;
        }
        public Account(decimal _balance)
        {
            OnCreateNewAccount();
            Balance = _balance;
        }
        public Account(Definition _definition, decimal _balance)
        {
            OnCreateNewAccount();
            Define = _definition;
            Balance = _balance;
        }
        #endregion
        #region Private methods
        private void OnCreateNewAccount()
        {
            idGenerate++;
            SetId();
        }
        private void SetId()
        {
            id = idGenerate;
        }
        private WithdrawlErrors CheckWithdraw(decimal _withdrawSumm)
        {
            if((Balance - _withdrawSumm) >= 0)
            {
                return WithdrawlErrors.Ok;
            }
            if((Balance - _withdrawSumm) < 0)
            {
                return WithdrawlErrors.InsufficientFunds;
            }
            else
            {
                return WithdrawlErrors.UnexpectedError;
            }
        }
        #endregion
        #region Public methods
        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id}\n\rType:{Define}\n\rBalance:{Balance}\n\r");
        }
        public void Deposit(decimal summ)
        {
            Balance += summ;
            Console.WriteLine($"Deposit {summ} successful\n\rLeft Balance:{Balance}\n\r");
        }
        public WithdrawlErrors Withdrawl(decimal summ)
        {
            var result = CheckWithdraw(summ);
            if(result != WithdrawlErrors.Ok)
            {
                Console.WriteLine($"Did not manage withdrawl {summ}. Error:{result}\n\rLeft Balance:{Balance}\n\r");
                return result;
            }
            else
            {
                Balance -= summ;
                Console.WriteLine($"Withdrawl {summ} successful\n\rLeft Balance:{Balance}\n\r");
                return result;
            }
        }
        #endregion
    }
}
