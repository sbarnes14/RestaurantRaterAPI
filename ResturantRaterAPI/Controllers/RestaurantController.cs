using ResturantRaterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResturantRaterAPI.Controllers
{
    public class RestaurantController : ApiController
    {
        private RestaurantDbContext _context = new RestaurantDbContext();

        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (model == null)
            {
                return BadRequest("your request body cannot be empty");
            }

            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                 await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
