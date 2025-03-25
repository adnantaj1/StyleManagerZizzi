using Microsoft.AspNetCore.Mvc;
using StyleManagerApiZizzi.Data;
using StyleManagerApiZizzi.Models;

namespace StyleManagerApiZizzi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ColorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateColor([FromBody] ColorDto dto)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            var color = new Color
            {
                ColorNumber = dto.ColorNumber,
                ColorName = dto.ColorName
            };

            _context.Colors.Add(color);
            await _context.SaveChangesAsync();
            return Ok(color);
        }
    }
}
