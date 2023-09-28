using Academic_event_management.API.Data;
using Academic_event_management.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academic_event_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicEventsController : ControllerBase
    {
        public DataContext _context;

        public AcademicEventsController(DataContext context)
        {
            _context = context;
        }

        //Get an academic event.
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var AcademicEvent = await _context.AcademicEvents.FirstOrDefaultAsync(x => x.Id == Id);

            if (AcademicEvent == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(AcademicEvent);
            }
        }

        //Get a list of academic events.
        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            var AcademicEventsList = await _context.AcademicEvents.ToListAsync();

            if (AcademicEventsList.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(AcademicEventsList);
            }
        }

        //Insert an academic event.
        [HttpPost]
        public async Task<ActionResult> Post(AcademicEvent academicEvent)
        {

            _context.Add(academicEvent);
            await _context.SaveChangesAsync();
            return Ok(academicEvent);
        }

        //Update an academic event.
        [HttpPut]
        public async Task<ActionResult> Put(AcademicEvent academicEvent)
        {

            _context.Update(academicEvent);
            await _context.SaveChangesAsync();
            return Ok(academicEvent);
        }

        //Delete an academic event.
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var AcademicEvent = await _context.AcademicEvents.Where(x => x.Id == Id).ExecuteDeleteAsync();

            if (AcademicEvent == 0)
            {

                return NotFound();

            };

            return NoContent();
        }
    }
}
