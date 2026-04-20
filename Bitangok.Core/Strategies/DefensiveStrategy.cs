using Bitangok.Core.Strategies;
public class DefensiveStrategy : IAttackStrategy
{
    public int CalculateDamage(int baseDamage) => (int)(baseDamage * 0.8);
}