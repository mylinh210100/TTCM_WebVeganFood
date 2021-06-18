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
        public int Serial { get; set; }

        public int IdOrder { get; set; }

        [StringLength(50)]
        public string IdFood { get; set; }

        [StringLength(50)]
        public string IdDrink { get; set; }

        [StringLength(50)]
        public string IdCombo { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double IntoMoney { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Drink Drink { get; set; }

        public virtual Food Food { get; set; }

        public virtual Order Order { get; set; }
    }
}
