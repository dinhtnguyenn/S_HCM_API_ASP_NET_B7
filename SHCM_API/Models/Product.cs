namespace SHCM_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dinhntco.Product")]
    public partial class Product
    {
        [Key]
        public int No { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int Price { get; set; }
    }
}
