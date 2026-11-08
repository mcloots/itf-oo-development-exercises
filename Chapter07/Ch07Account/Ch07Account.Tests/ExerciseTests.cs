using Xunit;
using Ch07Account;

namespace Ch07Account.Tests;

public class ExerciseTests
{
    [Fact]
    public void SuccessAndExactDepletion()
    {
        var account = new BankAccount(50m);
        account.Withdraw(20m);
        Assert.Equal(30m, account.Balance);
        account.Withdraw(30m);
        Assert.Equal(0m, account.Balance);
        Assert.Equal(0m, new BankAccount(0m).Balance);
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(31)]
    public void RefusalPreservesBalanceAndRemainsUsable(int amount)
    {
        var account = new BankAccount(30m);
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(amount));
        Assert.Equal(30m, account.Balance);
        account.Withdraw(2m);
        Assert.Equal(28m, account.Balance);
    }
    [Fact]
    public void NegativeOpeningBalanceThrows()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new BankAccount(-1m));
    }

}
