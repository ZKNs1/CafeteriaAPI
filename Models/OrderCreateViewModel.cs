using Microsoft.AspNetCore.Mvc.Rendering;
namespace Cafeteria.Models;
public class OrderCreateViewModel
{ 
    public List<Product> Products {get; set;} = new List<Product>(); //Resgata todos os produtos do BD
    public IEnumerable<SelectListItem>? ProductsSelectList { get; set; } = new List<SelectListItem>(); //Lista de produtos disponiveis
    public int SelectedProductId {get; set;} //Armazena o ID do produto
    public int Quantity {get; set;} //Quantidade do produto
    public decimal TotalPrice {get; set;} //Preço total
    public string? Message {get; set;} //Caso o produto selecionado esteja em falta (abaixo da quantidade pedida)
}