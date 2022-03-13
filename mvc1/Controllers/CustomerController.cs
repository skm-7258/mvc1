using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class CustomerController : Controller
    {
        private mvc1DbContext DbContext;
        public CustomerController(mvc1DbContext dbContext)
        {
            this.DbContext = dbContext;

        }
        public IActionResult Index()
        {
            List<Location>
                locations = DbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int Id)
        {
            List<Customers> customers =
                DbContext.Customers.Where(e =>
                e.Location.Id== Id).ToList();
            return View(customers);
        }

     
    }
}
