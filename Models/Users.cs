﻿using System.ComponentModel.DataAnnotations;

namespace PetEmotionsApp.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
