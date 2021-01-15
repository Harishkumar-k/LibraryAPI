using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ViewModel
{
    public class UserBookStatus
    {
        public int Book_Id { get; set; }
        public string Book_Name { get; set; }
        public DateTime Date_of_Issue { get; set; }
        public DateTime Return_Date { get; set; }
    }
}
