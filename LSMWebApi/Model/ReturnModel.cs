using LSMWebApi.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMWebApi.Model
{
    public class ReturnModel
    {
        public int Return_Id { get; set; }

        [ForeignKey("Borrowers")]
        public int Borrower_Id { get; set; }
      
        [ForeignKey("Staffs")]
        public int Staff_Id { get; set; }
   

        [Column(TypeName = "DateTime")]
        public DateTime Date_Borrowed { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Expected_Return { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date_Actual_Return { get; set; }

        [Column(TypeName = "bit")]
        public bool Is_Returned { get; set; }

        [Column(TypeName = "int")]
        public int Count_Book_Returned { get; set; }

        [Column(TypeName = "bit")]
        public bool Is_Defaulter { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Date_Created { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Edited { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Date_Deleted { get; set; }
    }
}
