using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAppV2.Core.Enums;

namespace LibraryAppV2.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string isbn, int year)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Year = year;
            Status = BookStatusEnum.Available;

        }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int Year { get; private set; }

        public List<BookComment> CommentList { get; private set; } = new List<BookComment>();
        public BookStatusEnum Status { get; private set; }
}
}
