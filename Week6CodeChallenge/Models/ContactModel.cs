using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week6CodeChallenge.Models
{
    [MetadataType(typeof(ContactModel))]
    public partial class W6ContactForm
    {

    }

    public class ContactModel
    {
        [Required(ErrorMessage = "The First Name field is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The Last Name field is required.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Phone Number field is required.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "The Phone Number field is not a valid phone number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The Company Name field is required.")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "The Project Description field is required.")]
        public string ProjectDescription { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}