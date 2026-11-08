using Xunit;
using Ch05LibraryQueries;

namespace Ch05LibraryQueries.Tests;

public class ExerciseTests
{
    [Fact]
    public void QueriesFilterSortProjectAndPreserveSource()
    {
        var catalog = new LibraryCatalog();
        Assert.Empty(catalog.GetAvailableBooks());
        Assert.Empty(catalog.GetAvailableTitles());
        Assert.Empty(catalog.GetCodes());
        Assert.Null(catalog.FindByCode("missing"));
        var zoo = new Book("B1", "Zoo", true);
        var alpha = new Book("B2", "Alpha", true);
        Assert.True(catalog.AddBook(zoo));
        Assert.True(catalog.AddBook(alpha));
        Assert.True(catalog.AddBook(new Book("B3", "Hidden", false)));
        Assert.False(catalog.AddBook(null));
        Assert.False(catalog.AddBook(new Book("B1", "Duplicate", true)));
        Assert.Equal(new[] { "Alpha", "Zoo" }, catalog.GetAvailableTitles());
        Assert.Equal(new[] { alpha, zoo }, catalog.GetAvailableBooks());
        Assert.Same(zoo, catalog.FindByCode("B1"));
        Assert.Equal(new[] { "B1", "B2", "B3" }, catalog.GetCodes());
        catalog.GetAvailableBooks().Clear();
        catalog.GetCodes().Clear();
        Assert.Equal(3, catalog.Count);
        Assert.Equal(2, catalog.GetAvailableBooks().Count);
        zoo.IsAvailable = false;
        alpha.Title = "Changed";
        Assert.Equal(new[] { "Changed" }, catalog.GetAvailableTitles());
    }

}
