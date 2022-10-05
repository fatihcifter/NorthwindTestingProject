namespace TodoApi.Models
{
    public class Employess
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public string titleOfCourtesy { get; set; }
        public string birthDate { get; set; }
        public string hireDate { get; set; }
        public Address address { get; set; }
        public string notes { get; set; }
        public string reportsTo { get; set; }
        public List<int> territoryIds { get; set; }

    }

}
