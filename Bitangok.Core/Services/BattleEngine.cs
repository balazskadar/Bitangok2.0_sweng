using Bitangok.Core.Models;

namespace Bitangok.Core.Services;

public class BattleResult
{
    public string Player1Name { get; set; } = "";
    public string Player2Name { get; set; } = "";
    public List<string> BattleLog { get; set; } = new();
    public string Winner { get; set; } = "";
    public bool IsDraw { get; set; } = false;
}

public class BattleEngine
{
    public BattleResult SimulateFight(ICharacter p1, ICharacter p2)
    {
        var result = new BattleResult
        {
            Player1Name = p1.Name,
            Player2Name = p2.Name
        };

        int round = 1;
        while (p1.Health > 0 && p2.Health > 0 && round <= 50)
        {
            int dmg1 = p1.Attack();
            p2.TakeDamage(dmg1);
            result.BattleLog.Add($"{round}. kör: {p1.Name} megütötte {p2.Name}-t. Sebzés: {dmg1}. ({p2.Name} HP: {p2.Health})");

            if (p2.Health <= 0) break;

            int dmg2 = p2.Attack();
            p1.TakeDamage(dmg2);
            result.BattleLog.Add($"{round}. kör: {p2.Name} megütötte {p1.Name}-t. Sebzés: {dmg2}. ({p1.Name} HP: {p1.Health})");

            round++;
        }

        if (p1.Health <= 0 && p2.Health <= 0) result.IsDraw = true;
        else result.Winner = p1.Health > 0 ? p1.Name : p2.Name;

        return result;
    }
}