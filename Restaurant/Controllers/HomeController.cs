using Microsoft.AspNetCore.Mvc;

namespace RestaurantControllers
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