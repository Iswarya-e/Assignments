using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Assignment9MVC3.Models
{
    public class Employee
    {


        [Required(ErrorMessage = "Name should not be null")]
        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [Display(Name = "First Name:")]
        public string FName { get; set; }


        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [Display(Name = "Last Name:")]
        public string LName { get; set; }


        [Display(Name = "Age:")]
        [Required(ErrorMessage = "Age should not be null")]
        [Range(18, 100, ErrorMessage = "Age should be between 18 and 100")]
        public int Age { get; set; }


        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email should not be null")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        public string Email { get; set; }


        [Display(Name = "Gender:")]
        public string Gender { get; set; }


        [Display(Name = "Address:")]
        [Required(ErrorMessage = "Address should not be null")]
        [StringLength(100, ErrorMessage = "Limit exceeded")]
        public string Address { get; set; }


        [Display(Name = "City:")]
        [Required(ErrorMessage = "City should not be null")]
        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string City { get; set; }



        [Display(Name = "State:")]
        [Required(ErrorMessage = "State should not be null")]
        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string State { get; set; }




        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile_number { get; set; }
        [Display(Name = "Educational Qualification:")]
        public string Educational_Qualification { get; set; }

    }
}