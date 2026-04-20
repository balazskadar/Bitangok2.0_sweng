using Bitangok.Core.Strategies;
public class AggressiveStrategy : IAttackStrategy
{
    public int CalculateDamage(int baseDamage) => (int)(baseDamage * 1.5);
}