using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Models;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O Título é obrigatório")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "A Descrição é obrigatória")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "O Autor é obrigatório")] 
    public string Author { get; set; } = string.Empty;

    [Required(ErrorMessage = "A quantidade de páginas é obrigatório")]
    public int Pages { get; set; }

    [Required(ErrorMessage = "O preço é obrigatório")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public DateTime? CreateAt { get; set; }
}
