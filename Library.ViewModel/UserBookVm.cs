using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ViewModel
{
    public class UserBookVm
    {
        public int User_ID { get; set; }
        public int Status_Id { get; set; }
        public int Book_id { get; set; }
        public int UserBook_id { get; set; }
        public string Book_Name { get; set; }
        public DateTime Date_of_Issue { get; set; }
        public DateTime Return_Date { get; set; }
        public string UserBookStatus { get; set; }
        public int New_Book_Count { get; set; }
        public int Fine_Amount { get; set; }
        public string Author_Name { get; set; }
        public DateTime User_Return_Date { get; set; }

    }
}
