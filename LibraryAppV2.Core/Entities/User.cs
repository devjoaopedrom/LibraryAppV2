
namespace LibraryAppV2.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;
        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; } = false;
        public List<Book>? OwnedBooks { get; private set; }
        public List<BookComment> Comments { get; private set; }
    }
}
