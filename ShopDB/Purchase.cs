namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchase")]
    public partial class Purchase
    {
        [Key]
        public int purchase_id { get; set; }

        public int product_id { get; set; }

        public int amount { get; set; }

        public int income_id { get; set; }
    
    }
}
