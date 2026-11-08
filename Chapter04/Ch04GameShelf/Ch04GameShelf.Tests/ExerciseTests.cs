using Xunit;
using Ch04GameShelf;

namespace Ch04GameShelf.Tests;

public class ExerciseTests
{
    [Fact]
    public void ShelfOperationsKeepOriginalObjects()
    {
        var shelf = new GameShelf("Club");
        Assert.Equal("Club", shelf.Name);
        Assert.Equal("No games.", shelf.GetReport());
        Assert.Null(shelf.FindByCode("G1"));
        Assert.False(shelf.RemoveByCode("G1"));
        var game = new Game("G1", "Azul", 4);
        Assert.True(shelf.AddGame(game));
        Assert.True(shelf.AddGame(new Game("G2", "Patchwork", 2)));
        Assert.False(shelf.AddGame(new Game("G1", "Duplicate", 2)));
        Assert.False(shelf.AddGame(null));
        Assert.Equal(2, shelf.Count);
        Assert.Same(game, shelf.FindByCode("G1"));
        Assert.Null(shelf.FindByCode("g1"));
        game.Title = "New title";
        Assert.Equal(new[] { game.GetDescription(), "G2 | Patchwork | players: 2" }, shelf.GetReport().Replace("\r", "").TrimEnd().Split('\n'));
        Assert.True(shelf.RemoveByCode("G1"));
        Assert.False(shelf.RemoveByCode("G1"));
        Assert.Null(shelf.FindByCode("G1"));
        Assert.Equal(1, shelf.Count);
    }
    [Theory]
    [InlineData(0, 2)]
    [InlineData(-1, 2)]
    [InlineData(1, 1)]
    [InlineData(8, 8)]
    [InlineData(9, 2)]
    public void PlayerBoundaries(int players, int expected)
    {
        var game = new Game("G1", "Azul", players);
        Assert.Equal(expected, game.RecommendedPlayers);
        game.RecommendedPlayers = 5;
        game.RecommendedPlayers = 9;
        Assert.Equal(5, game.RecommendedPlayers);
    }

}
