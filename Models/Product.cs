using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; } //Nome do produto
    public int Quantity { get; set; } //Quantidade
    public required string Category { get; set; } //Categoria
    public decimal Price { get; set; } //Preço
}