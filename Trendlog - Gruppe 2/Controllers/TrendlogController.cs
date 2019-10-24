using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trendlog___Gruppe_2.Data;
using Trendlog___Gruppe_2.Models;

namespace Trendlog___Gruppe_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendlogController : ControllerBase
    {
        private readonly TrendlogContext _context;

        public TrendlogController(TrendlogContext context)
        {
            _context = context;

            if (_context.Channels.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Channels.Add(new Channel { Name = "Item1" });
                _context.SaveChanges();
            }
        }
        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Channel>>> GetChannels()
        {
            return await _context.Channels.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Channel>> GetChannel(int id)
        {
            var channel = await _context.Channels.FindAsync(id);

            if (channel == null)
            {
                return NotFound();
            }

            return channel;
        }
    }
}
