using Bitangok.Core.Models;

namespace Bitangok.Core.Decorators;

public abstract class CharacterDecorator : ICharacter
{
    protected readonly ICharacter _decoratedCharacter;

    protected CharacterDecorator(ICharacter character) => _decoratedCharacter = character;

    public virtual string Name => _decoratedCharacter.Name;
    public virtual int Health { get => _decoratedCharacter.Health; set => _decoratedCharacter.Health = value; }
    public virtual int AttackPower => _decoratedCharacter.AttackPower;

    public virtual void TakeDamage(int damage) => _decoratedCharacter.TakeDamage(damage);
    public virtual int Attack() => _decoratedCharacter.Attack();
}