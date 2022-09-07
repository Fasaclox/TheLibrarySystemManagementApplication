using LSMWebApi.Context;
using LSMWebApi.Data;
using LSMWebApi.Model;
using LSMWebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LSMWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    
    public class StaffController : ControllerBase
    {

        private readonly ILSMRepository _lSMRepository;
        public StaffController(ILSMRepository lSMRepository)
        {
            _lSMRepository = lSMRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllStaffs()
        {
            var staffs = await _lSMRepository.GetAllStaffsAsync();
            return Ok(staffs);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaffById([FromRoute] int id)
        {
            var staff = await _lSMRepository.GetStaffByIdAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }
        [HttpPost("post")]
        public async Task<IActionResult> AddNewStaff([FromBody] StaffModel staffModel)
        {
            var id = await _lSMRepository.AddStaffAsync(staffModel);
            return CreatedAtAction(nameof(GetStaffById), new { id = id, controller = "staffs" }, id);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff([FromRoute] int id)
        {
            await _lSMRepository.DeleteStaffAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStaff([FromBody] StaffModel staffModel, [FromRoute] int id)
        {
            await _lSMRepository.UpdateStaffAsync(id, staffModel);
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateStaffPatch([FromBody] JsonPatchDocument staffModel, [FromRoute] int id)
        {
            await _lSMRepository.UpdateStaffPatchAsync(id, staffModel);
            return Ok();
        }
    }


}
