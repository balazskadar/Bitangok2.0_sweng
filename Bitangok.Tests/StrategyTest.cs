using Bitangok.Core.Strategies;
using Xunit;

namespace Bitangok.Tests;

public class StrategyTests
{
    [Fact]
    public void AggressiveStrategy_ShouldIncreaseDamageByTwentyPercent()
    {
        // Arrange
        var strategy = new AggressiveStrategy();
        int baseDamage = 100;

        // Act
        int finalDamage = strategy.CalculateDamage(baseDamage, 100, 100);

        // Assert
        Assert.Equal(120, finalDamage);
    }
}