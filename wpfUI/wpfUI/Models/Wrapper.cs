using System.Collections.Generic;

namespace NorthWind.Models
{
    public class wrapper
    {
        public List<Orders> order { get; set; }

        public List<Products> product { get; set; }
        public List<Categories> categories { get; set; }
        public List<Customers> customers { get; set; }
        public List<Suppliers> suppliers { get; set; }
        public List<Shippers> shippers { get; set; }
        public List<Employess> employess { get; set; }


    }
}
