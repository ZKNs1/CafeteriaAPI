using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime TimeStamp { get; set; } //Data/Hora do pedido
    public decimal TotalPrice { get; set; } //Preço total
}