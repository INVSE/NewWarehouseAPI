using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewWarehouseAPI.Models;

namespace NewWarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodDetailController : ControllerBase
    {
        private readonly GoodDetailContext _context;

        public GoodDetailController(GoodDetailContext context)
        {
            _context = context;
        }

        // GET: api/GoodDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoodDetail>>> GetGoodDetails()
        {
            return await _context.GoodDetails.ToListAsync();
        }

        // GET: api/GoodDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoodDetail>> GetGoodDetail(int id)
        {
            var goodDetail = await _context.GoodDetails.FindAsync(id);

            if (goodDetail == null)
            {
                return NotFound();
            }

            return goodDetail;
        }

        // PUT: api/GoodDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoodDetail(int id, GoodDetail goodDetail)
        {
            if (id != goodDetail.GoodDetailId)
            {
                return BadRequest();
            }

            _context.Entry(goodDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoodDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GoodDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GoodDetail>> PostGoodDetail(GoodDetail goodDetail)
        {
            _context.GoodDetails.Add(goodDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoodDetail", new { id = goodDetail.GoodDetailId }, goodDetail);
        }

        // DELETE: api/GoodDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoodDetail(int id)
        {
            var goodDetail = await _context.GoodDetails.FindAsync(id);
            if (goodDetail == null)
            {
                return NotFound();
            }

            _context.GoodDetails.Remove(goodDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GoodDetailExists(int id)
        {
            return _context.GoodDetails.Any(e => e.GoodDetailId == id);
        }
    }
}
