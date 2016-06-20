using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Order
    {
        public int Id { get; set; }

        [Display (Name = "Order date")]
        [DisplayFormat (DataFormatString ="{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required date")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped date")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Freight")]
        [Required(ErrorMessage = "This field is required.")]
        public double Freight { get; set; }

        [Display(Name = "Ship name")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipName { get; set; }

        [Display (Name = "Ship Address")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipAddress { get; set; }

        [Display (Name = "Ship City")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipCity { get; set; }

        [Display (Name = "Ship region")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipRegion { get; set; }

        [Display (Name = "Ship postal code")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipPostalCode { get; set; }

        [Display (Name = "Ship Country")]
        [Required(ErrorMessage = "This field is required.")]
        public string ShipCountry { get; set; }
    }
}
