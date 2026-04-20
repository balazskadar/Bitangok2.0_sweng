namespace Bitangok.Core.Models;

public class Rogue : ICharacter
{
    public string Name { get; set; } = "Bitang";
    public int Health { get; set; } = 90;
    public int AttackPower => 20;

    public void TakeDamage(int damage) => Health -= damage;
    public int Attack() => AttackPower;
}