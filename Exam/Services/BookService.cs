using Exam.DataAccess.Entites;
using Exam.Repositories;
using Exam.Services.DTOs;

namespace Exam.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepositories _bookRepository;
        public BookService()
        {
            _bookRepository = new BookRepositories();
        }
        public List<Book> GetAllBooksByAuthor(string author)
        {
            var books = _bookRepository.ReadAllBooks();
            var booksByAuthor = new List<Book>();
            foreach (var book in books)
            {
                if (book.Author == author)
                {
                    booksByAuthor.Add(book);
                }
            }
            return booksByAuthor;
        }
        public BookDto GetTopRatedBook()
        {
            var books = _bookRepository.ReadAllBooks();
            var bookRated = new BookDto();
            foreach (var book in books)
            {
                if (bookRated.Reting < book.Reting)
                {
                    return bookRated;
                }
            }
            throw new Exception($"Eror");
        }
        public List<BookDto> GetBooksPublishedAfterYear(int year)
        {
            var books = _bookRepository.ReadAllBooks();
            var booksGetYear = new List<Book>();
            foreach (var book in books)
            {
                if (book.PublishesDate == year)
                {
                    booksGetYear.Add(book);
                }
            }
            return booksGetYear;
        }
        public BookDto GetMostPobulerBook()
        {
            var books = _bookRepository.ReadAllBooks();
            var bookRated = new BookDto();
            foreach (var book in books)
            {
                if (bookRated.Pages > book.Pages)
                {
                    return bookRated;
                }
            }
            throw new Exception($"Eror");
        }
        public List<BookDto> SearchBooksByTitle(string keyword)
        {
            var books = _bookRepository.ReadAllBooks();
            var booksKeyword = new List<Book>();
            foreach (var book in books)
            {
                if (book.Title == keyword)
                {
                    booksKeyword.Add(book);
                }
            }
            return booksKeyword;
        }
        public Guid AddStudent(BookDto bookDto)
        {
            var entity = ConverToEntity(bookDto);
            var id = _bookRepository.WriteBook(entity);
            return id;
        }

        public void DeleteStudent(Guid bookId)
        {
            _bookRepository.RemoveBook(bookId);
        }

        public BookDto GetStudentById(Guid bookId)
        {
            var entity = _bookRepository.GetBookById(bookId);
            var dto = ConvertToDto(entity);
            return dto;
        }


        public void UpdateBook(BookUpdateDto bookUpdateDto)
        {
            var entity = ConverToEntity(bookUpdateDto);
            _bookRepository.UpdateBook(entity);
        }

        private Book ConverToEntity(BookDto bookDto)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = bookDto.Title,
                Author = bookDto.Author,
                Pages = bookDto.Pages,
                Reting = bookDto.Reting,
                NumberOfCopiesSold = bookDto.NumberOfCopiesSold,
            };
        }

        private Book ConverToEntity(BookUpdateDto bookUpdateDto)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = bookUpdateDto.Title,
                Author = bookUpdateDto.Author,
                Pages = bookUpdateDto.Pages,
                Reting = bookUpdateDto.Reting,
                NumberOfCopiesSold = bookUpdateDto.NumberOfCopiesSold,
            };
        }
        private BookDto ConvertToDto(Book book)
        {
            return new BookDto
            {
                Id = Guid.NewGuid(),
                Title = book.Title,
                Author = book.Author,
                Pages = book.Pages,
                Reting = book.Reting,
                NumberOfCopiesSold = book.NumberOfCopiesSold,
            };
        }


        public List<BookDto> GetBooksWithinPageRange(int minPages, int maxPages)
        {
            throw new NotImplementedException();
        }

        public int GetTotalCopiesSoldByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<BookDto> GetBooksSortedByRating()
        {
            throw new NotImplementedException();
        }

        public List<BookDto> GetRecentBook(int year)
        {
            throw new NotImplementedException();
        }

        List<BookDto> IBookService.GetAllBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }
    }
}
