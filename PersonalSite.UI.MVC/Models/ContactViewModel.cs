﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is Required*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Must provide message content*")]
        [UIHint("MultilineText")] //Provides a textarea in the UI
        public string Message { get; set; }
    }
}