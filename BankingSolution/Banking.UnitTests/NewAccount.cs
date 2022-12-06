using Banking.Domain;
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
            var account = new BankAccount();

            decimal balance = account.getBalance();

            Assert.Equal(5000M, balance);
        }
    }
}
