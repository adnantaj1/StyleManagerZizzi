using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StyleManagerApiZizzi.Data;
using StyleManagerApiZizzi.Models;
using StyleManagerApiZizzi.Models.DTOs;

namespace StyleManagerApiZizzi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StylesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StylesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateStyle([FromBody] CreateStyleDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Optional: validate FK existence
            var colorExists = await _context.Colors.AnyAsync(c => c.Id == dto.ColorId);
            var sizeExists = await _context.Sizes.AnyAsync(s => s.Id == dto.SizeId);

            if (!colorExists || !sizeExists)
                return BadRequest("Invalid ColorId or SizeId");

            var style = new Style
            {
                StyleNumber = dto.StyleNumber,
                ColorId = dto.ColorId,
                SizeId = dto.SizeId
            };

            _context.Styles.Add(style);
            await _context.SaveChangesAsync();

            return Ok(style); // or return CreatedAtAction(...) if you like
        }


        [HttpGet]
        public async Task<IActionResult> GetAllStyles()
        {
            var styles = await _context.Styles
                .Include(s => s.Color)
                .Include(s => s.Size)
                .ToListAsync();

                var result = styles.Select(s => new StyleDto
                {
                    StyleNumber = s.StyleNumber,
                    ColorName = s.Color?.ColorName ?? string.Empty,
                    SizeName = s.Size?.SizeName ?? string.Empty,
                })
                .ToList();

            return Ok(result);
        }

    }
}
