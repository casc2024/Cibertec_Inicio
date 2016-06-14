using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Client
    {
        public int Id { get; set; }
        
        [Display(Name = "First Name")]
        [Required (ErrorMessage = "This field is required")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [Required (ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }
    }
}