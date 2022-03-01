using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment8.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id should not be null")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name should not be null")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age should not be null")]
        [Range(18, 100, ErrorMessage = "Age should be between 18 and 100")]
        public int Age { get; set; }
        public string City { get; set; }
    }
}