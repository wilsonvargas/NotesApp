using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.WebApi.Models
{
    public class NoteTag
    {
        public Guid NoteId { get; set; }
        public virtual Note Note { get; set; }
        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
