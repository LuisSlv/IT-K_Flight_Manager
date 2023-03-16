﻿using FlightManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Data.Models
{
    public class Company
    {
        public Company()
        {
            Users = new HashSet<User>();
            Fligths = new HashSet<Flight>();
        }

        [Key]
        public int CompanyID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name should be at least 3 characters!")]
        public string CompanyName { get; set; }
        [Required]
        [MaxLength(130)]
        public string Password { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Location should be at least 10 characters!")]
        public string CompanyLocation { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Flight> Fligths { get; set; }

        public ICollection<CompaniesUsers> CompaniesUsers { get; set; }
    }
}
