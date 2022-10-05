using System.Collections.Generic;

namespace NorthWind.Models
{
    public class Detail
    {
        public double productId { get; set; }
        public double unitPrice { get; set; }
        public double quantity { get; set; }
        public double discount { get; set; }
    }

    public class Orders
    {
        public int id { get; set; }
        public string customerId { get; set; }
        public int employeeId { get; set; }
        public string orderDate { get; set; }
        public string requiredDate { get; set; }
        public string shippedDate { get; set; }
        public double shipVia { get; set; }
        public double freight { get; set; }
        public string shipName { get; set; }
        public ShipAddress shipAddress { get; set; }
        public List<Detail> details { get; set; }
    }

    public class ShipAddress
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }


}
