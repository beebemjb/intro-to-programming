using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.TestDoubles
{
    internal class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountToDeposit)
        {
            return 0;
        }
    }
}
