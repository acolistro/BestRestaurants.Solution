using System.Collections.Generic;
using System;

namespace BestRestaurants.Models
{
public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<CuisineRestaurant>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CuisineRestaurant> Restaurants { get; set; }
  }
}