using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Data
{
  
    public class Borrower
    {
        [Key]
        public int Borrower_Id { get; set; }

        [Column(TypeName = "int")]
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }

        [Column(TypeName = "int")]
        public int Staff_Id { get; set; }
        public Staff Staff { get; set; }

        [Column(TypeName = "int")]
        public int BookISBN_Id { get; set; }
        public Book Book { get; set; }

        [Column(TypeName = "bit")]
        public bool Is_Borrowed { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Borrowed { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Expected_Return { get; set; }

        [Column(TypeName = "int")]
        public int Count_Book_Borrowed { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }

    }
}
