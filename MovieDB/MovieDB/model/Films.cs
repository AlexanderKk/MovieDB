using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.model
{
    public class Films
    {
        public Films()
        { }
      
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; } 
        public float Rating { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Tagline { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime? Premiere { get; set; }
        public int Duration { get; set; }
        public string FilePath { get; set; }
        public string FilmDescription { get; set; }

        public virtual ICollection<Attachments> Attachments { get; set; }
    }
}
