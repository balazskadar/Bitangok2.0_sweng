using Bitangok.Core.Models;

namespace Bitangok.Core.Equipments;

public abstract class WeaponDecorator : ICharacter
{
	protected readonly ICharacter _character;
	public WeaponDecorator(ICharacter character) => _character = character;

	public virtual string Name => _character.Name;
	public virtual int Health { get => _character.Health; set => _character.Health = value; }
	public virtual int AttackPower => _character.AttackPower;
	public virtual void TakeDamage(int damage) => _character.TakeDamage(damage);
	public virtual int Attack() => _character.Attack();
}