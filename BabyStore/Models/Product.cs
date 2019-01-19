using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BabyStore.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product namebetween 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage ="Please enter a product name made up of letters and number only")]
        public string Name { get; set; }
        [Required(ErrorMessage ="The Description cannot be blank")]
        [StringLength(200,MinimumLength =5,ErrorMessage ="Please enter a product description between 5 and 200 characters in length")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a productdescription made up of letters and numbers only")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="The product price cannot be blank")]
        [Range(0.10,1000,ErrorMessage ="Please enter product price between 0.10 and 1000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:c}")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}