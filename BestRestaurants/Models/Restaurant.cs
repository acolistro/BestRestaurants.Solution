using System.Collections.Generic;
using System;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Cuisines = new HashSet<CuisineRestaurant>();
    }

    public int RestaurantId { get; set; }

    public string Name {get ; set; }

    public int Rating {get ; set; }
    public string Description { get; set; }
    public int CuisineId { get; set; }
    public ICollection<CuisineRestaurant> Cuisines { get; }
  } 
   
}

