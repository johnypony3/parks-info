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
            new ParkInfo(true, "Denali", "AK"),
            new ParkInfo(true, "Great Smoky Mountains ", "VI"),
            new ParkInfo(true, "Congaree ", "WY"),
            new ParkInfo(true, "Lake Chelan State Park", "WA")
        };

    }
}

