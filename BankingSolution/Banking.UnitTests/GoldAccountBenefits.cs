﻿using Banking.Domain;
using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Fact]
        public void GetBonusOnDeposit()
        {

            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.getBalance();
            var amountToDeposit = 100M;
            var expectedBonus = 10M;

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit + expectedBonus, account.getBalance());
        }
    }
}
