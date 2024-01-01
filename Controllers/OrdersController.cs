using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BLL;
using BOL;
namespace Portal.Controllers;

public class OrdersController : Controller
{
    private readonly ILogger< OrdersController> _logger;

    public  OrdersController(ILogger< OrdersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatlogManager mgr=new CatlogManager();
        List<Orders> lst=mgr.GetOrders();
        ViewData["Order"]=lst;
        return View();
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
