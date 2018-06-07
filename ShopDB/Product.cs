namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
       
        public Product()
        {
    
        }

        [Key]
        public int product_id { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        public string measure { get; set; }

        public int? amount { get; set; }

        public int? expiry { get; set; }

        [Column(TypeName = "money")]
        public decimal buyprice { get; set; }

        [Column(TypeName = "money")]
        public decimal sellprice { get; set; }

    }
}
