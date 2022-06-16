using Microsoft.AspNetCore.Mvc;
using park_info.Attributes;

namespace park_info.Controllers.V2;

[ApiController]
[Route("v2/[controller]")]
[ApiKey]
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

// GET      parks/          (List)
// GET      parks/parkId    (single object)
// DELETE   parks/          (delete list of objects)
// DELETE   parks/parkId    (delete single object)