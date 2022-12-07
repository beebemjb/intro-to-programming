namespace Banking.Domain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        public StandardBonusCalculator()
        {
        }

        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountToDeposit)
        {
            return currentBalance >= 5000 ? amountToDeposit * .10M : 0;
        }
    }
}