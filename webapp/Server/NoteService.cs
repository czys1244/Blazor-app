using webapp.Shared;

namespace webapp.Server
{
    public class NoteService
    {
        public List<Note> _notes;

        public NoteService()
        {
            _notes = new List<Note>();
        }

        public List<Note> GetNotes()
        {
            return _notes;
        }

        public void AddNote(Note note)
        {
            bool exists = false;
            foreach (var n in _notes)
            {
                if (n.Title == note.Title)
                {
                    exists = true; break;
                }
            }
            if (exists)
            {
                _notes.Find(a => a.Title == note.Title).Text = note.Text;
            }
            else
            {
                _notes.Add(note);
            }
        }

        public void DeleteNote(string title)
        {
            _notes.RemoveAll(a=>a.Title==title);
        }

    }
}
