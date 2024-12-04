using LibraryManagerApi.Enums;

namespace LibraryManagerApi.DTOs;

public class UpdateBookDTO
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public GenderEnum? Gender { get; set; }
    public double? Price { get; set; }
    public int? Quantity { get; set; }
}
