using System.ComponentModel.DataAnnotations;
using ProductCatagories2019.Resources;

namespace ProductCatagories2019.Models
{
    internal class ProductsMetadata
    {   [Required(ErrorMessageResourceType =typeof(WebResourcel),ErrorMessageResourceName = "ProductNameEmpty")]
        [Display(Name = "ProductName",ResourceType =typeof(WebResourcel))]
        [StringLength(40,ErrorMessage ="{0}最多{1}個字元")]//限制最多字元
        public string ProductName { get; set; }
        [Required(ErrorMessage = "{0}未填寫!")]
        [Display(Name = "商品單價")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public decimal? UnitPrice { get; set; }
        [Required(ErrorMessage = "{0}未填寫!")]
        [Display(Name = "訂購數量")]
        [Range(1,100,ErrorMessage = "{0}必須介於最低訂購量{1}最高訂購量{2}")]

        public short? UnitsOnOrder { get; set; }

    }
}