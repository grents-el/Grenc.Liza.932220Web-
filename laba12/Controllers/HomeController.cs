using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab12.Models;

namespace Lab12.Controllers;

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
    [HttpGet]
    public IActionResult ModelBuildingInParameters()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ModelBuildingInParameters(double first, string action, double second)
    {
        ViewBag.result = Сalculator(first, action, second);
        return View();
    }

    [HttpGet]
    public IActionResult ModelBuildingInSeparateModel()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ModelBuildingInSeparateModel(FormData data)
    {
        ViewBag.result = Сalculator(data.First, data.Action, data.Second);
        return View();
    }

    public IActionResult Manual([FromForm]double first, [FromForm]string action, [FromForm]double second)
    {
        if (Request.Method == "POST")
        {
            ViewBag.result = Сalculator(Double.Parse(Request.Form["first"]), Request.Form["action"], Double.Parse(Request.Form["second"]));
        }
        return View();
    }

    [HttpGet, ActionName("ManualWithSeparateHandlers")]
    public IActionResult ManualWithSeparateHandlersGet()
    {
        return View();
    }

    [HttpPost, ActionName("ManualWithSeparateHandlers")]
    public IActionResult ManualWithSeparateHandlersPost()
    {
        ViewBag.result = Сalculator(Double.Parse(Request.Form["first"]), Request.Form["action"], Double.Parse(Request.Form["second"]));
        return View();
    }

    private string Сalculator(double first, string action, double second)
    {
        switch (action)
        {
            case "+":
                return $"{first} + {second} = " + (first + second);
            case "-":
                return $"{first} - {second} = " + (first - second);
            case "*":
                return $"{first} * {second} = " + (first * second);
            case "/":
                return $"{first} / {second} = " + (first / second);
        }
        return "";
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
