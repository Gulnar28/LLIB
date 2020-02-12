using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LLIB.Models
{
    public enum UserLevel
    {
        Admin,
        Moderator
    }

    public class User
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public UserLevel Level { get; set; }

    }
}