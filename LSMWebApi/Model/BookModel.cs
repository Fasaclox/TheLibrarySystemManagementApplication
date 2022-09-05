using LSMWebApi.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Model
{
    public class BookModel
    {
        public int BookISBN_Id { get; set; }

        [Column(TypeName = "int")]
        [ForeignKey("Bindings")]
        public int Binding_Id { get; set; }

        [Column(TypeName = "int")]
        [ForeignKey("Categories")]
        public int Category_Id { get; set; }


        [Column(TypeName = "int")]
        [ForeignKey("Shelves")]
        public int Shelf_Id { get; set; }

        [Column(TypeName = "varchar(250")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(250")]
        public string Author { get; set; }

        [Column(TypeName = "int")]
        public int Edition { get; set; }

        [Column(TypeName = "varchar(250")]
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
