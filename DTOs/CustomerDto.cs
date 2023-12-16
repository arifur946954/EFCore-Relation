using EfCoreRelation.Entity;

namespace EfCoreRelation.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public List<CustomerAddressDTO> customerAddresses { get; set; }
    }
}
