using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{
   
    public class Binding
    {
        [Key]
        public int Binding_Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Binding_Name { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }
    }
}
