using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BonusCalculation
{
    public class BonusesForBankAccountDeposits
    {
        [Fact]
        public void AccountsWithProperBalanceGetBonus()
        {
            var bonusCalculator = new StandardBonusCalculator();

            decimal bonus = bonusCalculator.GetBonusForDepositOn(5000M, 100M);

            Assert.Equal(10M, bonus);
        }

        [Fact]
        public void AccountsWithProperBalanceGetNoBonus()
        {
            var bonusCalculator = new StandardBonusCalculator();

            decimal bonus = bonusCalculator.GetBonusForDepositOn(4999.99M, 100M);

            Assert.Equal(0M, bonus);
        }
    }
}
