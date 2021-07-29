using System.Collections.Generic;
namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public override string ToString()
    {
      return $"id: {CuisineId} | name:{CuisineName}";
    }
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CuisineId {get; set; }
    public string CuisineName {get; set;}
    public virtual ICollection<Restaurant> Restaurants { get; set; }
    
  }
}