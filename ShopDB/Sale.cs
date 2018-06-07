namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [Key]
        public int sale_id { get; set; }

        public int product_id { get; set; }

        public int client_id { get; set; }

        public int amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateofsale { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }
    }



}
