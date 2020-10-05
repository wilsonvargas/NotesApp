using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.WebClient.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public Guid UserId { get; set; }
    }
}
