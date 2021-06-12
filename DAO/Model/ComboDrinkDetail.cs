namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboDrinkDetail")]
    public partial class ComboDrinkDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(10)]
        public string IdCombo { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50)]
        public string IdDrink { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public double? Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Drink Drink { get; set; }
    }
}
