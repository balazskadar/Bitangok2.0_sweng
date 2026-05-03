using Bitangok.Core.Models;
using Bitangok.Core.Decorators;
using Xunit;

namespace Bitangok.Tests;

public class DecoratorTests
{
    [Fact]
    public void FlamingSword_ShouldAddTenToBaseAttack()
    {
        // Arrange
        var baseWarrior = new Warrior { Name = "Leo" };
        var sword = new FlamingSword(baseWarrior);

        // Act
        int totalDamage = sword.Attack();

        // Assert
        Assert.Equal(25, totalDamage);
    }
}