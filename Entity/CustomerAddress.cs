namespace EfCoreRelation.Entity
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
