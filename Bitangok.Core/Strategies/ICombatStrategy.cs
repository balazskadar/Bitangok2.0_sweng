namespace Bitangok.Core.Strategies;

public interface ICombatStrategy
{
    // A stratégia eldönti, a karakter ereje és életereje alapján mennyit sebez
    int CalculateDamage(int baseAttack, int currentHealth, int maxHealth);
}