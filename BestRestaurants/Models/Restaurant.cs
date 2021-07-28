namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string RestaurantName { get; set;}
    public string RestaurantLocation {get; set;}
    public int CuisineId {get; set;}
    public virtual Cuisine Cuisine {get; set; }
  }
}