using Bitangok.Core.Models;

namespace Bitangok.Core.Decorators;

public class FlamingSword : CharacterDecorator
{
    public FlamingSword(ICharacter character) : base(character) { }

    public override string Name => $"{_decoratedCharacter.Name} (Lángoló Karddal)";

    // fix +10 sebzést ad a támadáshoz
    public override int Attack() => _decoratedCharacter.Attack() + 10;
}