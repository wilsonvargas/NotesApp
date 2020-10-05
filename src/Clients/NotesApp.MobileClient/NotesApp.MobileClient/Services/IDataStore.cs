using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.MobileClient.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddNoteAsync(T item);
        Task<bool> UpdateNoteAsync(T item);
        Task<bool> DeleteNoteAsync(string id);
        Task<T> GetNoteAsync(string id);
        Task<IEnumerable<T>> GetNotesAsync(bool forceRefresh = false);
    }
}
