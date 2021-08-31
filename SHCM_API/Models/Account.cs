namespace SHCM_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int No { get; set; }

        [Required]
        [StringLength(10)]
        public string MSSV { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public int? Score { get; set; }
    }
}
