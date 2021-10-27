using System;

namespace OOP_HW
{
    /// <summary>
    /// Definition of possible account types
    /// </summary>
    public enum Definition 
    {
        NotDefined,
        Credit,
        Current,
        Deposit,
        Budget,
        Payment
    };
    class Account
    {

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



        public Account()
        {
            OnCreateNewAccount();
        }
        public Account(Definition _definition) : this()
        {
            Define = _definition;
        }
        public Account(decimal _balance) : this()
        {
            Balance = _balance;
        }
        public Account(
            Definition _definition,
            decimal _balance) : this()
        {
            Define = _definition;
            Balance = _balance;
        }



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



        /// <summary>
        /// Information about Account Fields
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id}\n\rType:{Define}\n\rBalance:{Balance}\n\r");
        }
        /// <summary>
        /// Deposit of funds to account
        /// </summary>
        /// <param name="summ">amount of funds that will be deposited to account</param>
        public void Deposit(decimal summ)
        {
            Balance += summ;
            Console.WriteLine($"Deposit {summ} successful\n\rLeft Balance:{Balance}\n\r");
        }
        /// <summary>
        /// Withdrawl of funds from account
        /// </summary>
        /// <param name="summ">amount of funds that will be withdrawn from account</param>
        /// <returns>enum of possible results of operation</returns>
        public OperationCode Withdrawl(decimal summ)
        {
            var result = CheckWithdraw(summ);
            if (result.Code != Codification.Ok)
            {
                Console.WriteLine($"Did not manage withdrawl {summ}. Error:{result.Code}\n\rLeft Balance:{Balance}\n\r");
                return result;
            }
            else
            {
                Balance -= summ;
                Console.WriteLine($"Withdrawl {summ} successful\n\rLeft Balance:{Balance}\n\r");
                return result;
            }
        }
        /// <summary>
        /// Transfer of funds between 2 accounts
        /// </summary>
        /// <param name="summ">amount of funds that would be withdrawn from object of account and deposited to the recepient</param>
        /// <param name="recepient">Account that recieves summ</param>
        /// <returns>enum of possible results of operation</returns>
        public OperationCode Transfer(
            decimal summ,
            Account recepient)
        {
            var result = CheckTransfer(summ);
            switch (result.Code)
            {
                case 0:
                    WithdrawFromBalance(summ);
                    recepient.DepositOnBalance(summ);
                    Console.WriteLine($"Transfer of summ {summ} from account {Id} to account {recepient.Id} is successful\n\r");
                    return result;
                default:
                    Console.WriteLine($"Error {result.Code} while transfer of summ {summ} from account {Id} to account {recepient.Id}\n\r");
                    return result;
            }

        }



        private void OnCreateNewAccount()
        {
            idGenerate++;
            SetId();
        }
        private void SetId()
        {
            id = idGenerate;
        }
        private void DepositOnBalance(decimal _depositSumm)
        {
            Balance += _depositSumm;
        }
        private OperationCode CheckWithdraw(decimal _withdrawSumm)
        {
            if((Balance - _withdrawSumm) >= 0)
            {
                return new OperationCode(Codification.Ok);
            }
            if((Balance - _withdrawSumm) < 0)
            {
                return new OperationCode(Codification.InsufficientFunds);
            }
            else
            {
                return new OperationCode(Codification.UnexpectedError);
            }
        }
        private void WithdrawFromBalance(decimal _withdrawSumm)
        {
            Balance -= _withdrawSumm;
        }
        private OperationCode CheckTransfer(decimal _transferSumm)
        {
            return CheckWithdraw(_transferSumm);
        }
    }
}
