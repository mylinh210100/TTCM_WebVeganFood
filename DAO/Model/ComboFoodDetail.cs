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

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(10, ErrorMessage = "maximum is 10 characters")]
        public string IdCombo { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50, ErrorMessage = "maximum is 50 characters")]
        public string IdFood { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public double? Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Food Food { get; set; }
    }
}
