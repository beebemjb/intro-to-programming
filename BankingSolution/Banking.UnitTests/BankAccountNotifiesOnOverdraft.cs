using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class BankAccountNotifiesOnOverdraft
    {

        [Fact]
        public void TheBankAccountNotifiesIfThereIsAnOverdraft()
        {
            var mockedNotifier = new Mock<INotifyAccountReps>();
            var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockedNotifier.Object);
            var openingBalance = account.GetBalance();
            var amountToWithdraw = account.GetBalance() + 1M;

            try
            {
                account.Withdraw(amountToWithdraw);
            }
            catch (Exception)
            {
                //igore
            }
            mockedNotifier.Verify(m => m.NotifyOfAttemptedOverdraft(account, openingBalance, amountToWithdraw));
        }

        [Fact]
        public void TheBankAccountDoesNotNotifiesIfThereIsNOAnOverdraft()
        {

        }
    }
}
