﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.DTOs
{
    public class UserRequestDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
    }
}
