using Exam.DataAccess.Entites;

namespace Exam.Repositories
{
    public interface IBookRepositories
    {
        Guid WriteBook(Book book);
        List<Book> ReadAllBooks();
        void RemoveBook(Guid studentId);
        Book GetBookById(Guid bookId);
        void UpdateBook(Book book);
    }
}