using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class User
    {
        public User()
        {
        }

        [Key]
        public Guid UserId { get; set; }

        [Display(Name = "User Name")]
        [StringLength(100)]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Full Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        public DateTime CreateAt { get; set; }

        public string applicationUserId { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}
