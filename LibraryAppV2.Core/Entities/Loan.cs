using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppV2.Core.Entities
{
    public class Loan :BaseEntity
    {
        public Loan(int bookId, Book book, int borrowerdId, User borrower, DateTime loanDate, DateTime? returnDate)
        {
            BookId = bookId;
            Book = book;
            Borrower = borrower;
            LoanDate = DateTime.Now;
            ReturnDate = returnDate;
        }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BorrowerId { get; set; }
        public User Borrower { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public bool IsReturned => ReturnDate.HasValue;
    }
}
