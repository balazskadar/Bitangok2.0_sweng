namespace Bitangok.Core.Strategies;

public class AggressiveStrategy : ICombatStrategy
{
    // Mindig 20% bónusz sebzést ad a karakter alap támadásához, függetlenül az életerő szintjétől
    public int CalculateDamage(int baseAttack, int currentHealth, int maxHealth) => (int)(baseAttack * 1.2);
}