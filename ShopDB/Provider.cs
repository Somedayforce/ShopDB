namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Provider
    {
   
        public Provider()
        {

        }

        [Key]
        public int provider_id { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Column("product name")]
        [Required]
        [StringLength(10)]
        public string product_name { get; set; }

        [Required]
        [StringLength(15)]
        public string adress { get; set; }

        public int discount { get; set; }


    }
}
