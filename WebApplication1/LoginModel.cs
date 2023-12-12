namespace FormEncode.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Login
    {
        [Required]
        [MaxLength(140)]
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}