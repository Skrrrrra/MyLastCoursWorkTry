namespace MyLastCoursWorkTry.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userlogpass")]
    public partial class userlogpass
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string password { get; set; }

        internal static void Load()
        {
            throw new NotImplementedException();
        }
    }
}
