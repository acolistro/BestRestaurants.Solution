namespace BestRestaurants.Models
{
  public class CuisineRestaurant
    {       
        public int CuisineRestaurantId { get; set; }
        public int RestaurantId { get; set; }
        public int CuisineId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}