﻿namespace SistemaApp.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
