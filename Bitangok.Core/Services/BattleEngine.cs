using Bitangok.Core.Models;

namespace Bitangok.Core.Services;

public class BattleEngine
{
    public void Fight(ICharacter c1, ICharacter c2)
    {
        while (c1.Health > 0 && c2.Health > 0)
        {
            int dmg1 = c1.Attack();
            c2.TakeDamage(dmg1);
            Console.WriteLine($"{c1.Name} megütötte {c2.Name}-t ({dmg1} sebzés).");

            if (c2.Health <= 0) break;

            int dmg2 = c2.Attack();
            c1.TakeDamage(dmg2);
            Console.WriteLine($"{c2.Name} megütötte {c1.Name}-t ({dmg2} sebzés).");
        }

        string winner = c1.Health > 0 ? c1.Name : c2.Name;
        Console.WriteLine($"A gyõztes: {winner}!");
    }
}