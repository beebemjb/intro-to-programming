using Banking.Domain;
using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class OverdraftOfAccount
    {

        [Fact]
        public void CanTakeAllTheMoney()
        {
            var account = new BankAccount(new DummyBonusCalculator());

            account.Withdraw(account.getBalance());

            Assert.Equal(0, account.getBalance());
        }

        [Fact]
        public void OverdraftDoesNotDecreaseTheBalance()
        {
            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.getBalance();
            var amountToWithDraw = openingBalance + .01M;

            // Exceptional Behavior
            try
            {
                account.Withdraw(amountToWithDraw); //  "No-op"
            }
            catch (OverdraftException)
            {

                // Ignore it.
            }

            Assert.Equal(openingBalance, account.getBalance());
        }

        [Fact]
        public void OverdraftThrowsAnOverdraftException()
        {
            var account = new BankAccount(new DummyBonusCalculator());

            Assert.Throws<OverdraftException>(() =>
            {
                account.Withdraw(account.getBalance() + 1);
            });
        }
    }


}
