using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Theory]
        [InlineData(100)]
        public void MakingDepositsIncreasesBalances(decimal amountToDeposit) 
        {
            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.getBalance();

            account.Deposit(amountToDeposit);

            Assert.Equal(amountToDeposit + openingBalance, account.getBalance());
        }

        [Theory]
        [InlineData(100)]
        public void MakingWithdrawlsDecreasesBalances(decimal amountToWithdraw)
        {
            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.getBalance();

            account.Withdraw(amountToWithdraw);

            Assert.Equal(openingBalance - amountToWithdraw, account.getBalance());
        }
    }
}
