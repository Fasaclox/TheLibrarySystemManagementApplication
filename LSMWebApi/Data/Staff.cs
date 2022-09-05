using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{

    public class Staff
    {
        [Key]
        public int Staff_Id { get; set; }

        [Column(TypeName = " varchar(30)")]
        public string First_Name { get; set; }

        [Column(TypeName = " varchar(30)")]
        public string Last_Name { get; set; }

        [Column(TypeName = " varchar(30)")]
        public string? Middle_Name { get; set; }

        [Column(TypeName = " varchar(10)")]
        public string Gender { get; set; }

        [Column(TypeName = " varchar(30)")]
        public string Designation { get; set; }

        [Column(TypeName = "bit")]
        public bool Is_Admin { get; set; }

        [Column(TypeName = " varchar(50)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Phone_Number { get; set; }

        [Column(TypeName = " varchar(30)")]
        public string Email { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }

    }
}
