namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Decommission")]
    public partial class Decommission
    {
        [Key]
        public int decommission_id { get; set; }

        public int product_id { get; set; }

        [Column("manufacture date", TypeName = "date")]
        public DateTime manufacture_date { get; set; }

        [Column("expiry term", TypeName = "date")]
        public DateTime expiry_term { get; set; }

        [Column("deccom date", TypeName = "date")]
        public DateTime deccom_date { get; set; }

        public int amount { get; set; }

    }
}
