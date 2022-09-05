using Microsoft.AspNetCore.Identity;

namespace LSMWebApi.Model
{
    public class LSMStaffUser : IdentityUser
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }


    }
}
