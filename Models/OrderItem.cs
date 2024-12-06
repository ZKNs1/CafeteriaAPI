using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int IdProduct { get; set; } //ID do produto
    public int IdOrder { get; set; } //Id do pedido
    public int Quantity { get; set; } //Quantidade
}