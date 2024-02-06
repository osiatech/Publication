
using System;
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? MiddleInitial { get; set; }
        public int JobId { get; set; }
        public int? JobLevel { get; set; }
        public int PublisherId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
