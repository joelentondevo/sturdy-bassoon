namespace FormEncode.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;

    public class LoginModel
    {
        [Required]
        [MaxLength(140)]

        public string username { get; set; }
        public string password { get; set; }
    }
}