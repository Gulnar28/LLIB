using System;
using System.Collections.Generic;
using LLIB.Data;
using System.ComponentModel.DataAnnotations;

namespace LLIB.Models
{
    public class Customer
    {


        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }

       
    }
}
        


    

