

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class MakingWithdrawals
{

    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingWithdrawalsDecreasesBalance(decimal amountToWithdraw)
    {
        // Given
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, new Mock<INotifyAccountReps>().Object);
        var openingBalance = account.GetBalance();

        // When
        account.Withdraw(amountToWithdraw);

        // Then
        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }
}
