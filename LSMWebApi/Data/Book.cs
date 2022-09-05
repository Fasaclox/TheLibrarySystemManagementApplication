using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{
    public class Book
    {
        [Key]
        public int BookISBN_Id { get; set; }

        [Column(TypeName = "int")]
        public int Binding_Id { get; set; }
        public Binding Binding { get; set; }

        public int Category_Id { get; set; }
        public Category Category { get; set; }

        public int Shelf_Id { get; set; }
        public Shelf Shelf { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Author { get; set; }

        [Column(TypeName = "int")]
        public int Edition { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Language { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Year_Published { get; set; }

        [Column(TypeName = "int")]
        public int Number_Actual_Copies { get; set; }

        [Column(TypeName = "int")]
        public int Number_Current_Copies { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }
    }
}
