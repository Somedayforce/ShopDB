namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Income")]
    public partial class Income
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Income()
        {
       
        }

        [Key]
        public int income_id { get; set; }

        public DateTime incomedate { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int provider_id { get; set; }

 
    }
}
