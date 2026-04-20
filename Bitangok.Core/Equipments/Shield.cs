using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class Shield : WeaponDecorator
{
    public Shield(ICharacter character) : base(character) { }

    public override void TakeDamage(int damage)
    {
  
        int reducedDamage = Math.Max(0, damage - 5);
        _character.TakeDamage(reducedDamage);
    }
}