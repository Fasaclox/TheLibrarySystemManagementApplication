using LSMWebApi.Model;
using LSMWebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LSMWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class LSMAccountController : ControllerBase
    {
        private readonly ILSMAccountRepository _lSMAccountRepository;

        public LSMAccountController(ILSMAccountRepository lSMAccountRepository)
        {
            _lSMAccountRepository = lSMAccountRepository;
        }

    
        [HttpPost("signup")]
         public async Task<IActionResult> SignUp([FromBody] SignUpModel signUpModel) 
        {
            var result = await _lSMAccountRepository.SignUpAsync(signUpModel);

            if (result.Succeeded)
            {
               
                return Ok(result.Succeeded);

            }
            return Unauthorized();


        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SignInModel signInModel)
        {
            var result = await _lSMAccountRepository.LoginAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {

                return Unauthorized();

            }
            return Ok(result);


        }
    } 
}
