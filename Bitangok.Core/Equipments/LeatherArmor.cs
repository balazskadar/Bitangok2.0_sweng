using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class LeatherArmor : WeaponDecorator
{
    public LeatherArmor(ICharacter character) : base(character) { }

    public override int Health
    {
        get => _character.Health + 20;
        set => _character.Health = value;
    }
}