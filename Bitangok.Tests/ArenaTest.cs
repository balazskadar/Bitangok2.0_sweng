using Moq;
using Xunit;
using Bitangok.Core.Models;
using Bitangok.Core;
using Bitangok.Core.Strategies;

namespace Bitangok.Tests;

public class ArenaTests
{
    [Fact]
    public void Arena_Duel_ShouldEndWhenSomeoneDies()
    {
        // Arrange
        var mockPlayer1 = new Mock<ICharacter>();
        var mockPlayer2 = new Mock<ICharacter>();
        var mockStrategy = new Mock<ICombatStrategy>();


        mockPlayer1.Setup(p => p.IsAlive).Returns(true);
        mockPlayer1.Setup(p => p.Name).Returns("Teszt Hős");
        mockPlayer1.Setup(p => p.Attack()).Returns(10);

        mockPlayer2.Setup(p => p.IsAlive).Returns(false);
        mockPlayer2.Setup(p => p.Name).Returns("Teszt Gonosz");

        var arena = new Arena(mockStrategy.Object);

        arena.StartDuel(mockPlayer1.Object, mockPlayer2.Object);

        // Assert
        mockPlayer2.Verify(p => p.IsAlive, Times.AtLeastOnce());
    }
}