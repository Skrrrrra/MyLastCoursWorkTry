namespace MyLastCoursWorkTry.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("studentslogpass")]
    public partial class studentslogpass
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ID { get; set; }
    }
}
