using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{

    public class Shelf
    {

        [Key]
        public int Shelf_Id { get; set; }

        [Column(TypeName = "int")]
        public int Shelf_Number { get; set; }

        [Column(TypeName = "int")]
        public int Floor_Number { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }
    }
}
