using Xunit;
using Ch06PrinterPlanning;

namespace Ch06PrinterPlanning.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(0, "")]
    [InlineData(-1, "")]
    [InlineData(21, "P1,P2,P3")]
    [InlineData(30, "P2,P3")]
    [InlineData(42, "P3")]
    [InlineData(43, "")]
    public void WidthQueries(int width, string codes)
    {
        var shop = new PrintShop();
        Assert.Empty(shop.GetSuitableCodes(width));
        Assert.True(shop.AddPrinter(new PhotoPrinter("P2", 0.40m, 30)));
        Assert.True(shop.AddPrinter(new PhotoPrinter("P1", 0.25m, 21)));
        Assert.True(shop.AddPrinter(new PhotoPrinter("P3", 0.60m, 42)));
        Assert.False(shop.AddPrinter(null));
        Assert.False(shop.AddPrinter(new PhotoPrinter("P2", 1m, 50)));
        Assert.Equal(codes, string.Join(",", shop.GetSuitableCodes(width)));
        shop.GetSuitableCodes(width).Clear();
        Assert.Equal(3, shop.Count);
        Assert.Equal(codes, string.Join(",", shop.GetSuitableCodes(width)));
    }
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(10)]
    public void InheritedPrintCost(int pages)
    {
        var printer = new PhotoPrinter("P1", 0.40m, 30);
        Assert.IsAssignableFrom<Printer>(printer);
        Assert.Equal(0.40m * Math.Max(0, pages), printer.GetPrintCost(pages));
        var invalid = new PhotoPrinter("P2", -1m, -1);
        Assert.Equal(0m, invalid.CostPerPage);
        Assert.Equal(0, invalid.MaxWidth);
        Assert.False(invalid.CanPrintWidth(1));
    }

}
