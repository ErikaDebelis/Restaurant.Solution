using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public RestaurantsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "CuisineName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(string cuisineName, string RestaurantName, int cuisineId)
    {
      // forgot all this
      int newCuisineId = cuisineId;
      
      if (cuisineName != null)
      {
        // create a new cuisine
        Cuisine newCuisine = new Cuisine();
        newCuisine.CuisineName = cuisineName;
        _db.Cuisines.Add(newCuisine);
        _db.SaveChanges(); // saves db with new cuisine in cuisines table
        // (entity framework core) efcore does have access to id after SaveChanges();
        newCuisineId = newCuisine.CuisineId;
      }
      
      Restaurant newRestaurant = new Restaurant();
      newRestaurant.RestaurantName = RestaurantName;
      newRestaurant.CuisineId = newCuisineId;
      _db.Restaurants.Add(newRestaurant);
      _db.SaveChanges();
  
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
    public ActionResult Edit(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "CuisineName");
      return View(thisRestaurant);
    }
    [HttpPost]
    public ActionResult Edit (Restaurant restaurant)
    {
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfired(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}