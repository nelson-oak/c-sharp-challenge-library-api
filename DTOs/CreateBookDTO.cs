using LibraryManagerApi.Enums;

namespace LibraryManagerApi.DTOs;

public class CreateBookDTO
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public GenderEnum Gender { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}
