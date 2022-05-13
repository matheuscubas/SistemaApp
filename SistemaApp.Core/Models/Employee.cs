﻿using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class Employee
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(2)]
        public string FirstName { get; set; }

        [Index(1)]
        public string LastName { get; set; }

        [Index(3)]
        public DateTime BirthDate { get; set; }

        [Index(4)]
        public string Photo { get; set; }

        [Index(5)]
        public string Notes { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
