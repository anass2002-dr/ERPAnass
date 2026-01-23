using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.JournalEntryService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {
        private readonly IServiceJournalEntry _journalEntryService;

        public JournalEntryController(IServiceJournalEntry journalEntryService)
        {
            _journalEntryService = journalEntryService;
        }

        [HttpGet("GetJournalEntries")]
        public ActionResult<IEnumerable<JournalEntry>> GetJournalEntries()
        {
            return Ok(_journalEntryService.GetJournalEntries());
        }

        [HttpGet("GetJournalEntryById/{id}")]
        public ActionResult<JournalEntry> GetJournalEntryById(int id)
        {
            var entry = _journalEntryService.GetJournalEntryById(id);
            if (entry == null) return NotFound();
            return Ok(entry);
        }

        [HttpPost("AddJournalEntry")]
        public ActionResult<JournalEntry> AddJournalEntry(JournalEntryDtos entry)
        {
            try
            {
                return Ok(_journalEntryService.AddJournalEntry(entry));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateJournalEntry/{id}")]
        public ActionResult<JournalEntry> UpdateJournalEntry(int id, JournalEntry entry)
        {
            var updated = _journalEntryService.UpdateJournalEntry(id, entry);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteJournalEntry/{id}")]
        public IActionResult DeleteJournalEntry(int id)
        {
            if (!_journalEntryService.DeleteJournalEntry(id)) return NotFound();
            return NoContent();
        }
    }
}
