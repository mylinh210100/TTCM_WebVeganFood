namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serial { get; set; }

        [StringLength(50)]
        public string IdFood { get; set; }

        [StringLength(50)]
        public string IdDrink { get; set; }

        [StringLength(10)]
        public string IdCombo { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Drink Drink { get; set; }

        public virtual Food Food { get; set; }

        public virtual Order Order { get; set; }
    }
}
