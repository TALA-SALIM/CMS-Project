using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CMS.web.Models;

namespace CMS.web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.UserType = "Administrator";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}