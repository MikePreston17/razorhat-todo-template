using Microsoft.AspNetCore.Mvc;

namespace RazorHAT_Template.Controllers;

[Produces("application/json")]
[Route("api/Car")]
public class CarController : Controller
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    // GET: api/Car
    [HttpGet]
    public IEnumerable<Car> Get()
    {
        return _carService.ReadAll();
    }
}