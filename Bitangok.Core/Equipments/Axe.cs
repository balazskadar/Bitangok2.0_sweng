using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class Axe : WeaponDecorator
{
	public Axe(ICharacter character) : base(character) { }

	public override int Attack() => _character.Attack() + 10;
}