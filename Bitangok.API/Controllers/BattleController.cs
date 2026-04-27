using Microsoft.AspNetCore.Mvc;
using Bitangok.Core.Models;
using Bitangok.Core.Equipments;
using Bitangok.Core.Services;

namespace Bitangok.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BattleController : ControllerBase
{
    [HttpGet("quick-battle")]
    public IActionResult QuickBattle(string p1Name = "Harcos", string p2Name = "Mágus")
    {
        // 1. Karakterek létrehozása (Később itt jön be a Factory!)
        ICharacter p1 = new Sword(new Warrior { Name = p1Name });
        ICharacter p2 = new Mage { Name = p2Name };

        // 2. Harc szimulálása
        var engine = new BattleEngine();
        var result = engine.SimulateFight(p1, p2);

        // 3. Eredmény visszaküldése JSON-ben
        return Ok(result);
    }
}