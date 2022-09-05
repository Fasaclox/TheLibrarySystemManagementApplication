using LSMWebApi.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Model
{
    public class BorrowerModel
    {
        public int Borrower_Id { get; set; }

        [Column(TypeName = "int")]
        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }

        [Column(TypeName = "int")]
        [ForeignKey("Staffs")]
        public int Staff_Id { get; set; }

        [Column(TypeName = "int")]
        [ForeignKey("Books")]
        public int BookISBN_Id { get; set; }

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
