using Banking.Domain;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Fact]
        public void MakingDepositsIncreasesBalances() {
            var account = new BankAccount();
            var openingBalance = account.getBalance();
            var amountToDeposit = 100M;

            account.Deposit(amountToDeposit);

            Assert.Equal(amountToDeposit + openingBalance, account.getBalance());
        }
    }
}
