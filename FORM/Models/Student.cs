namespace FORM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [Column("_id")]
        public int id { get; set; }

        [Column("_Name")]
        [StringLength(30)]
        public string Name { get; set; }

        [Column("_FatherName")]
        [StringLength(30)]
        public string FatherName { get; set; }

        [Column("_MotherName")]
        [StringLength(30)]
        public string MotherName { get; set; }

        [Column("_Gender")]
        public string Gender { get; set; }

        [Column("_dob")]
        [StringLength(10)]
        public string dob { get; set; }

        [Column("_Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Column("_Department")]
        [StringLength(30)]
        public string Department { get; set; }

        [Column("_MobileNumber")]
        public int MobileNumber { get; set; }
    }
}
