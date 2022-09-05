using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{
    public class Defaulter
    {
        [Key]
        public int Defaulter_Id { get; set; }
        public int Return_Id { get; set; }
        public Return Return { get; set; }

        [Column(TypeName = "int")]
        public int Days_Defaulted { get; set; }

        [Column(TypeName = "int")]
        public int Penalty_Cost { get; set; }

        [Column(TypeName = "bit")]
        public bool Is_Paid { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Paid { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }

    }
}
