﻿using System.ComponentModel.DataAnnotations;

namespace GUI.GUIModels
{
    // Model for user input in SignUp page
    public class SignUpData
    {
        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}