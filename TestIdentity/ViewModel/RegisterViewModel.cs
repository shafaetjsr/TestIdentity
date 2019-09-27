﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestIdentity.ViewModel
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage ="username can't be Blank")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password can't be Blank")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password can't be Blank")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can't be Blank")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}