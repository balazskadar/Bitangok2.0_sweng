// Program.cs
using Bitangok.Core.Models;

var harcos = CharacterFactory.CreateCharacter("warrior", "Leó");
var varazslo = CharacterFactory.CreateCharacter("mage", "Gandalf");

Console.WriteLine($"{harcos.Name} HP: {harcos.Health}");
Console.WriteLine($"{varazslo.Name} HP: {varazslo.Health}");