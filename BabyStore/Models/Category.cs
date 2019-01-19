using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Đề nghị điền thông tin vào")]
        [StringLength(50, MinimumLength = 3,ErrorMessage ="Nội dung từ 3 đên 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage ="Ký tự đầu phải là chữ hoa")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}