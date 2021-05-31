using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "First Name Required.")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address Required.")]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "City Required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State Required.")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code Required.")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Phone Number Required.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //public int OrderDetailsId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        
        

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
