using Microsoft.AspNetCore.Mvc;

namespace BestRestaurants.controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
  {
    return View();
  }
  }
}