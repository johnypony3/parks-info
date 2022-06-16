using Microsoft.AspNetCore.Mvc;
using park_info.Attributes;

namespace park_info.Controllers.V1;

[ApiController]
[Route("v1/[controller]")]
public class ParkInfoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<ParkInfo> Get()
    {
        return new ParkInfo[] {
            new ParkInfo(1, true, "Denali", "AK"),
            new ParkInfo(2, true, "Great Smoky Mountains ", "VI"),
            new ParkInfo(3, true, "Congaree ", "WY"),
            new ParkInfo(4, true, "Lake Chelan State Park", "WA")
        };
    }

    [HttpPost]
    public IActionResult Create(ParkInfo parkInfo)
    {
        return Ok(new { message = $"Park {parkInfo.Name} has been created" });
    }
}

