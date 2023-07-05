using System.ComponentModel.DataAnnotations;

namespace ItemsCatalog.Dtos
{
  public record CreateItemDto
  {
    [Required]
    public string Name {get; init;}
    [Required]
    [Range(1, 1000)]
    public decimal Price {get; init;}
  }
}