using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public async Task<IActionResult> GetSizes()
        {
            var sizes = await _context.Sizes
                .Select(s => new SizeDto
                {
                    Id = s.Id,
                    SizeName = s.SizeName,
                    SizeNumber = s.SizeNumber
                })
                .ToListAsync();

            return Ok(sizes);
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
