namespace ToyFactory.Dal.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int PasspartCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FamilyName { get; set; }

        public string AddressLine { get; set; }
    }
}