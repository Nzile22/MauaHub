namespace MauaHub.Models;
using System.ComponentModel.DataAnnotations;
public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Range(0.01, 1000000)]
    public decimal SellingPrice { get; set; }
    [Range(0.01, 1000000)]
    public decimal CostPrice { get; set; }
    [Range(0.01, 1000000)]
    public int QuantityInStock { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}