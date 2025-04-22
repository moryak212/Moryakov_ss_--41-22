using Microsoft.AspNetCore.Mvc;
using Moryakov_КТ_41_22.Filters;
using Moryakov_КТ_41_22.Interfaces;

namespace Moryakov_КТ_41_22.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // POST api/teachers/filter
        [HttpPost("filter")]
        public async Task<IActionResult> GetByFilter([FromBody] TeacherFilter filter, CancellationToken cancellationToken)
        {
            var result = await _teacherService.GetByFilterAsync(filter, cancellationToken);
            return Ok(result);
        }
    }
}
