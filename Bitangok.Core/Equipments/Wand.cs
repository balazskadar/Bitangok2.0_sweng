using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class Wand : WeaponDecorator
{
    public Wand(ICharacter character) : base(character) { }

    public override int Attack() => _character.Attack() + 15;
}