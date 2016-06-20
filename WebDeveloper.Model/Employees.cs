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

        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "The Address is required.")]
        public string Address { get; set; }
    }
}
