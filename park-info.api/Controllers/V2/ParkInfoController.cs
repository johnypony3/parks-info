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
            new ParkInfo(true, "Denali", "AK"),
            new ParkInfo(true, "Great Smoky Mountains ", "VI"),
            new ParkInfo(true, "Congaree ", "WY"),
            new ParkInfo(true, "Lake Chelan State Park", "WA")
        };

    }
}

