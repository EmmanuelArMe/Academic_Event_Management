using Academic_event_management.API.Data;
using Academic_event_management.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academic_event_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        public DataContext _context;

        public AttendeesController(DataContext context)
        {
            _context = context;
        }

        //Get an attendee.
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var Attendee = await _context.Attendees.FirstOrDefaultAsync(x => x.Id == Id);

            if (Attendee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Attendee);
            }
        }

        //Get a list of attendees.
        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            var AttendeesList = await _context.Attendees.ToListAsync();

            if (AttendeesList.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(AttendeesList);
            }
        }

        //Insert an attendee.
        [HttpPost]
        public async Task<ActionResult> Post(Attendee Attendee)
        {

            _context.Add(Attendee);
            await _context.SaveChangesAsync();
            return Ok(Attendee);
        }

        //Update an attendee.
        [HttpPut]
        public async Task<ActionResult> Put(Attendee Attendee)
        {

            var AttendeeExist = await _context.Attendees.FirstOrDefaultAsync(x => x.Id == Attendee.Id);

            if (AttendeeExist == null)
            {
                return NotFound();
            }

            //We clean tracker for updating.
            _context.ChangeTracker.Clear();

            _context.Update(Attendee);
            await _context.SaveChangesAsync();
            return Ok(Attendee);
        }

        //Delete an attendee.
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var Attendee = await _context.Attendees.Where(x => x.Id == Id).ExecuteDeleteAsync();

            if (Attendee == 0)
            {

                return NotFound();

            };

            return NoContent();
        }
    }
}
