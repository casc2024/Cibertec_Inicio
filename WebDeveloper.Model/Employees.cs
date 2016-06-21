using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Employees
    {
        public int Id { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name is required.")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The First Name is required.")]
        public string FirstName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "The Address is required.")]
        public string Address { get; set; }
    }
}
