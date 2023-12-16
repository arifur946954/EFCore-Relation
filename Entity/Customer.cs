﻿namespace EfCoreRelation.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public List<CustomerAddress> customerAddresses { get; set; }

    }
}
