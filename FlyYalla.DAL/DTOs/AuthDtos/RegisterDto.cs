using FlyYalla.CU.CustomValidation;
using FlyYalla.CU.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyYalla.DAL.DTOs.AuthDtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserMail { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string ContactMail { get; set; }


        [Required(ErrorMessage = "Mobile number is required")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Document type is required")]
        public DocumentType DocumentType { get; set; }

        [Required(ErrorMessage = "Document number is required")]
        [RegularExpression(@"^[A-Za-z0-9]*$", ErrorMessage = "Invalid document number")]
        public string DocumentNumber { get; set; }

        [Required(ErrorMessage = "Issuing Country is required")]
        public string IssuingCountry { get; set; }

        [Required(ErrorMessage = "Document expiry date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DateInFuture(ErrorMessage = "Expiry date must be in the future")]
        public DateTime DocumentExpiryDate { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "You must agree to the Terms and Conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the Terms and Conditions")]
        public bool AgreeToTerms { get; set; }




    }
}
