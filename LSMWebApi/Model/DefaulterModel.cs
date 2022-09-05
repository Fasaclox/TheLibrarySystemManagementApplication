using LSMWebApi.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Model
{
    public class DefaulterModel
    {
        public int Defaulter_Id { get; set; }

        [ForeignKey("Returns")]
        public int Return_Id { get; set; }

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
