using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp.Shared;

namespace webapp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private NoteService _noteService;
        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        [Route("GetNotes")]
        public ActionResult<List<Note>> GetNotes()
        {
            return _noteService.GetNotes();
        }

        [HttpPost]
        [Route("AddNote")]
        public ActionResult AddNote([FromBody] Note note)
        {
            _noteService.AddNote(note);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteNote")]
        public ActionResult DeleteNote([FromQuery] string title)
        {
            _noteService.DeleteNote(title);
            return Ok();
        }

        
    }
}
