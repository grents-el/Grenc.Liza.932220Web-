using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;

namespace Lab11.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult PassUsingModel()
    {
        LabModel model = GetNewModel();

        return View(model);
    }

    public IActionResult PassUsingViewData()
    {
        ViewData["data"] = GetNewModel();

        return View();
    }

    public IActionResult PassUsingViewBag()
    {
        ViewBag.data = GetNewModel();

        return View();
    }

    public IActionResult PassUsingService()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public LabModel GetNewModel()
    {
        Random random = new Random(DateTime.Now.Second);
        var first = random.Next(0, 10);
        var second = random.Next(0, 10);

        int divResult;
        try
        {
            divResult = first / second;
        }
        catch (Exception)
        {
            divResult = -1;
        }

        return new LabModel
        {
            firstRndNum = first,
            secondRndNum = second,
            sumResult = first + second,
            subResult = first - second,
            divResult = divResult,
            mulResult = first * second
        };
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
