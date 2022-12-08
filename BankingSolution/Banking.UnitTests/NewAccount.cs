using Banking.Domain;
using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class NewAccount
    {
        public void HaveTheCorrectOpeningBalance()
        {
            var account = new BankAccount(new Mock<ICalculateBonuses>().Object, new Mock<INotifyAccountReps>().Object);

            decimal balance = account.GetBalance();

            Assert.Equal(5000M, balance);
        }
    }
}
