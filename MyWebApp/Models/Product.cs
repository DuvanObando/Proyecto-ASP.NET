using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [DataType(DataType.Currency)]
    [Precision(18, 2)]
    public decimal Price { get; set; }
}
