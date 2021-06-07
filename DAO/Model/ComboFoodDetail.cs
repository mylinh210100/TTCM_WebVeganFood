namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboFoodDetail")]
    public partial class ComboFoodDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10, ErrorMessage = "maximum of length is 10 charecters")]
        [Required(ErrorMessage = "you must input this field")]
        public string IdCombo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50, ErrorMessage = "maximum of length is 50 charecters")]
        [Required(ErrorMessage = "you must input this field")]
        public string IdFood { get; set; }

        public double? Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Food Food { get; set; }
    }
}
