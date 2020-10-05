using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.WebApi.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<NoteTag> NoteTags { get; set; }
        public virtual User User { get; set; }
    }
}
