namespace Bitangok.Core.Strategies;

public class DefensiveStrategy : ICombatStrategy
{
    // Ha 30% alatt van az életereje, csak fele erővel támad (mert védekezik)
    public int CalculateDamage(int baseAttack, int currentHealth, int maxHealth)
        => (currentHealth < maxHealth * 0.3) ? baseAttack / 2 : baseAttack;
}