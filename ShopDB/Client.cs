namespace ShopDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
       
       

        [Key]
        public int client_id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        public int? dept { get; set; }

        [Required]
        [StringLength(15)]
        public string adress { get; set; }

       
    }
}
