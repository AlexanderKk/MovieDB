using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieDB.model
{
    public class Users
    {
        public Users(){}
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string User { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Attachments> Attachments { get; set; }
    }
}
