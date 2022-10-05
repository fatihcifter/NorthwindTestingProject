namespace NorthWind.Models
{
    public class Suppliers
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public Addresses address { get; set; }


    }

}
