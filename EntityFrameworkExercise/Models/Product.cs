namespace EntityFrameworkExercise.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(4)]
        public string ProductNo { get; set; }

        [Required]
        [StringLength(30)]
        public string ProductName { get; set; }

        public int ProductQuantity { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductClass { get; set; }
    }
}
