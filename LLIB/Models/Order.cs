using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LLIB.Data;

namespace LLIB.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        [ForeignKey("OwnerUser")]
        public int UserId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        [Required]
        public bool IsDone { get; set; }

        public DateTime? DoneAt { get; set; }

        [MaxLength(500)]
        public string Result { get; set; }

        [MaxLength(50)]
        public string DoneUser { get; set; }

        public User OwnerUser { get; set; }

        public Customer Customer { get; set; }
    }
}