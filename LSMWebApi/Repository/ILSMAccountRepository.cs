using LSMWebApi.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace LSMWebApi.Repository
{
    public interface ILSMAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
