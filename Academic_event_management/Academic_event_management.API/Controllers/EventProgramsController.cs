using Academic_event_management.API.Data;
using Academic_event_management.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academic_event_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventProgramsController : ControllerBase
    {
        public DataContext _context;

        public EventProgramsController(DataContext context)
        {
            _context = context;
        }

        //Get an event program.
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var EventProgram = await _context.EventPrograms.FirstOrDefaultAsync(x => x.Id == Id);

            if (EventProgram == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(EventProgram);
            }
        }

        //Get a list of event programs.
        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            var EventProgramsList = await _context.EventPrograms.ToListAsync();

            if (EventProgramsList.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(EventProgramsList);
            }
        }

        //Insert an event program.
        [HttpPost]
        public async Task<ActionResult> Post(EventProgram eventProgram)
        {

            _context.Add(eventProgram);
            await _context.SaveChangesAsync();
            return Ok(eventProgram);
        }

        //Update an event program.
        [HttpPut]
        public async Task<ActionResult> Put(EventProgram EventProgram)
        {

            var EventProgramExist = await _context.EventPrograms.FirstOrDefaultAsync(x => x.Id == EventProgram.Id);

            if (EventProgramExist == null)
            {
                return NotFound();
            }

            //We clean tracker for updating.
            _context.ChangeTracker.Clear();

            _context.Update(EventProgram);
            await _context.SaveChangesAsync();
            return Ok(EventProgram);
        }

        //Delete an event program.
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var AcademicEvent = await _context.EventPrograms.Where(x => x.Id == Id).ExecuteDeleteAsync();

            if (AcademicEvent == 0)
            {

                return NotFound();

            };

            return NoContent();
        }
    }
}
