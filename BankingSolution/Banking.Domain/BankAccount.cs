namespace Banking.Domain
{
    public enum BankAccountType { Standard, Gold };
    public class BankAccount
    {
        
        private decimal _balance = 5000;
        public BankAccountType AccountType = BankAccountType.Standard;
        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
                throw new OverdraftException();
            }
            else
            {
                _balance -= amountToWithdraw;
            }
        }

        public decimal getBalance()
        {
            return _balance;
        }
    }
}