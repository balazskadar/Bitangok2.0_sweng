using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitangok.Core.Models;

public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    int AttackPower { get; }
    bool IsAlive => Health > 0;

    void TakeDamage(int damage);
    int Attack();
}
