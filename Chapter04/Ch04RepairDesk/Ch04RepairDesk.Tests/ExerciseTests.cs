using Xunit;
using Ch04RepairDesk;

namespace Ch04RepairDesk.Tests;

public class ExerciseTests
{
    [Fact]
    public void TotalsFollowCompletionAndSharedCustomer()
    {
        var customer = new Customer("C1", "Mina");
        var first = new RepairJob("J1", customer, 40m);
        var second = new RepairJob("J2", customer, 25m);
        var desk = new RepairDesk();
        Assert.Equal("No jobs.", desk.GetReport());
        Assert.True(desk.AddJob(first));
        Assert.True(desk.AddJob(second));
        Assert.False(desk.AddJob(null));
        Assert.False(desk.AddJob(new RepairJob("J1", customer, 99m)));
        Assert.Equal(2, desk.Count);
        Assert.Equal(65m, desk.GetOpenTotal());
        Assert.False(first.IsCompleted);
        first.Complete();
        first.Complete();
        Assert.True(first.IsCompleted);
        Assert.Equal(25m, desk.GetOpenTotal());
        Assert.Same(first, desk.FindByCode("J1"));
        Assert.Null(desk.FindByCode("missing"));
        Assert.Same(customer, first.Customer);
        customer.Name = "Noor";
        Assert.Contains("Noor", first.GetDescription());
        Assert.Contains("Noor", second.GetDescription());
        Assert.Equal(new[] { first.GetDescription(), second.GetDescription() }, desk.GetReport().Replace("\r", "").TrimEnd().Split('\n'));
        Assert.True(desk.RemoveByCode("J2"));
        Assert.False(desk.RemoveByCode("J2"));
        Assert.Equal(0m, desk.GetOpenTotal());
        Assert.Equal(1, desk.Count);
    }
    [Fact]
    public void NegativeQuoteIsIgnored()
    {
        var job = new RepairJob("J1", new Customer("C1", "Mina"), -1m);
        Assert.Equal(0m, job.QuotedCost);
        job.QuotedCost = 12.5m;
        job.QuotedCost = -1m;
        Assert.Equal(12.5m, job.QuotedCost);
        job.QuotedCost = 0m;
        Assert.Equal(0m, job.QuotedCost);
    }

}
