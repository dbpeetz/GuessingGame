using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGameChallenge.Models
{
    public class GameModel
    {


        [Display(Name="What is your name")]
        [Required(ErrorMessage ="You must enter your name")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        [MaxLength(16, ErrorMessage ="Name can't be longer than 16 characters")]
        public string PlayerName { get; set; }


        [Display(Name = "Enter your guess")]
        [Required(ErrorMessage ="You must enter a guess")]
        [Range(1, 10, ErrorMessage ="Guess must be between 1-10")]
        public int Guess { get; set; }

    }
}