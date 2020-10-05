using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.WebApi.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<NoteTag> NoteTags { get; set; }
        public virtual User User { get; set; }
    }
}
