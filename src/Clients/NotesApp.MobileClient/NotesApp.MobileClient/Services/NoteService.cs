using NotesApp.MobileClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.MobileClient.Services
{
    public class NoteService : IDataStore<Note>
    {
        public async Task<bool> AddNoteAsync(Note item)
        {
            var note = new Note
            {
                Title = item.Title,
                Description = item.Description,
                Content = item.Content,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow,
                UserId = new Guid("5ca7bee5-c362-4138-28e0-08d868cc3b04")
            };

            var response = await BackendService.Instance.PostHttpResponse(note, "api/notes");
            return response.IsSuccessStatusCode;
        }

        public Task<bool> DeleteNoteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Note> GetNoteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Note>> GetNotesAsync(bool forceRefresh = false)
        {
            var notes = await BackendService.Instance.Get<List<Note>>("api/notes");
            return notes;
        }

        public Task<bool> UpdateNoteAsync(Note item)
        {
            throw new NotImplementedException();
        }
    }
}
