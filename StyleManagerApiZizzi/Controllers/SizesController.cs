using Microsoft.AspNetCore.Mvc;
using StyleManagerApiZizzi.Data;
using StyleManagerApiZizzi.Models;

namespace StyleManagerApiZizzi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SizesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize([FromBody] SizeDto dto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var size = new Size
            {
                SizeNumber = dto.SizeNumber,
                SizeName = dto.SizeName
            };
            _context.Sizes.Add(size);
            await _context.SaveChangesAsync();
            return Ok(size);
        }
    }
}
