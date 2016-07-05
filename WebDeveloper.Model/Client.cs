using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Client
    {
        public int Id { get; set; }
        
        [Display(Name = "Client_Name", ResourceType = typeof(Resource))]
        [Required (ErrorMessage = "This field is required")]       
        public string Name { get; set; }

        [Display(Name = "Client_LastName", ResourceType = typeof(Resource))]
        [Required (ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }
    }
}