using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bitangok.Core.Models;

public static class CharacterFactory
{
    public static ICharacter CreateCharacter(string type, string name)
    {
        return type.ToLower() switch
        {
            "warrior" => new Warrior { Name = name },
            "mage" => new Mage { Name = name },
            _ => throw new ArgumentException("Ismeretlen karaktertípus!")
        };
    }
}