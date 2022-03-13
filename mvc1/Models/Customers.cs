using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class Customers
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile{ get; set; }
        public Location Location { get; set; }
    }
}
