using BlazorCrud.Data;
using BlazorCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Repository
{
    public class Repository : IRepository
    {

        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBook(Book createBook)
        {
            if (createBook != null)
            {
                createBook.CreateAt = DateTime.Now;
                await _context.Books.AddAsync(createBook);
                await _context.SaveChangesAsync();
                return createBook;
            }
            else
            {
                return new Book();
            }
        }

        public async Task DeleteBook(int BookId)
        {
            var book = await _context.Books.FindAsync(BookId);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookId(int BookId)
        {
            var book = await _context.Books.FindAsync(BookId);
            if(book == null)
            {
                return new Book();
            }

            return book;
        }

        public Task<List<Book>> GetBooks()
        {
            return _context.Books.ToListAsync();
        }

        public async Task<Book> UpdateBook(int BookId, Book updateBook)
        {
            var book = await _context.Books.FindAsync(BookId);
            book.Title = updateBook.Title;
            book.Description = updateBook.Description;
            book.Author = updateBook.Author;
            book.Pages = updateBook.Pages;
            book.Price = updateBook.Price;

            await _context.SaveChangesAsync();
            return book;
            
        }
    }
}
