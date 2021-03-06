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
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string IdCombo { get; set; }

        [Required]
        [StringLength(50)]
        public string IdFood { get; set; }

        [Required]
        public double? Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Food Food { get; set; }
    }
}
