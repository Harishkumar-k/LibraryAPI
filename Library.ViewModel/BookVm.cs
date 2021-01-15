using System;
using System.Collections.Generic;

namespace Library.ViewModel
{
    public class BookVm
    {
        public int Book_id { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public DateTime Date_of_release { get; set; }
        public string Rating { get; set; }
        public string BookCount { get; set; }
        public int New_Book_Count { get; set; }
        public string BooksCategory { get; set; }
        public int Rating_id { get; set; }
        public string BookImages { get; set; }
    }
}
