namespace MyLastCoursWorkTry.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentDB")]
    public partial class StudentDB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SecondName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ThirdName { get; set; }

        public int? Math { get; set; }

        public int? RussianLanguage { get; set; }

        public int? EnglishLanguage { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Grade { get; set; }
    }
}
