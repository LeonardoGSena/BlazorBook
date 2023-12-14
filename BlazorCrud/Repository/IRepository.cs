using BlazorCrud.Models;

namespace BlazorCrud.Repository;

public interface IRepository
{
    public Task<List<Book>> GetBooks();
    public Task<Book> GetBookId(int BookId);
    public Task<Book> CreateBook(Book createBook);
    public Task<Book> UpdateBook(int BookId, Book updateBook);
    public Task DeleteBook(int BookId);

}
