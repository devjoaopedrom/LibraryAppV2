namespace LibraryAppV2.Core.Entities
{
    public class BookComment
    {
        public BookComment(string content, int idBook, int idUser) 
        { 
            Content = content;
            IdBook = idBook;
            IdUser = idUser;
        }

        public string Content { get; private set; }
        public int IdBook { get; private set; }
        public Book Book { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
    }
}