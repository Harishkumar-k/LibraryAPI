using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Model
{
    [Table("Library_user")]
    public class UserM
    {
        [Key]
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile_Number { get; set; }
        public string User_Status { get; set; }
    }
}
