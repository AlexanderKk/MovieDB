using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.model
{
    public class Attachments
    {


        [Key]
        public int ID { get; set; }
        public bool? CheckView { get; set; }
        public int? NumberOfStars { get; set; }
        public string Comment { get; set; }
        public int? FilmsId { get; set; }
        public int? UsersID { get; set; }
        public DateTime? CommentTime { get; set; }
        public DateTime? RatingDate { get; set; }
        public DateTime? ViewDate { get; set; }
        public bool? FavoriteFilm { get; set; }

        public virtual Users Users { get; set; }
        public virtual Films Films { get; set; }
    }
}
