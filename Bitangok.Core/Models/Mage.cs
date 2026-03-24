using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitangok.Core.Models;

public class Mage : ICharacter
{
    public string Name { get; set; } = "Varázsló";
    public int Health { get; set; } = 80; 
    public int AttackPower => 25;        

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public int Attack()
    {
        return AttackPower;
    }
}
