using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitangok.Core.Models;

public class Warrior : ICharacter
{
    public string Name { get; set; } = "Harcos";
    public int Health { get; set; } = 120;
    public int AttackPower => 15;

    public void TakeDamage(int damage) => Health -= damage;
    public int Attack() => AttackPower;
}
