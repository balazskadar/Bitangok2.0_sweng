using Bitangok.Core.Models;
namespace Bitangok.Core.Equipments;

public class Chainmail : WeaponDecorator
{
    public Chainmail(ICharacter character) : base(character) { }

    public override int Health
    {
        get => _character.Health + 40;
        set => _character.Health = value;
    }
}