namespace Banking.Domain
{
    public class BankAccount
    {
        private readonly ICalculateBonuses _calculator;
        private decimal _balance = 5000;

        public BankAccount(ICalculateBonuses calculator)
        {
            _calculator = calculator;
        }

        public void Deposit(decimal amountToDeposit)
        {
            decimal bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;
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