using Exam.Services.DTOs;

namespace Exam.Services
{
    public interface IBookService
    {
        List<BookDto> GetAllBooksByAuthor(string author);
        BookDto GetTopRatedBook();
        List<BookDto> GetBooksPublishedAfterYear(int year);
        BookDto GetMostPobulerBook();
        List<BookDto> SearchBooksByTitle(string keyword);
        List<BookDto> GetBooksWithinPageRange(int minPages, int maxPages);
        int GetTotalCopiesSoldByAuthor(string author);
        List<BookDto> GetBooksSortedByRating();
        List<BookDto> GetRecentBook(int year);
    }
}