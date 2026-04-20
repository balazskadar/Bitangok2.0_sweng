using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class Sword : WeaponDecorator
{
    public Sword(ICharacter character) : base(character) { }

    public override int Attack() => _character.Attack() + 5;
}