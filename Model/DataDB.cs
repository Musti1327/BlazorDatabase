using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BlazorDB.Model
{
    public class DataDB
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string PhoneNum { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime Birthday { get; set; }


        
    }
}
