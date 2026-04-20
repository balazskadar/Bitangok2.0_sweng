using Bitangok.Core.Models;
using Bitangok.Core.Equipments;
using Bitangok.Core.Services;

var harcos = new Warrior { Name = "Leó" };
var feldiszitettHarcos = new Sword(new Shield(harcos));

var mage = new Mage { Name = "Gandalf" };

var engine = new BattleEngine();
engine.Fight(feldiszitettHarcos, mage);