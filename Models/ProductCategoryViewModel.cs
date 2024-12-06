using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Cafeteria.Models;

public class ProductCategoryViewModel
{
    public List<Product>? Products { get; set; } //Produtos
    public SelectList? Categories { get; set; } //Categorias disponiveis
    public string? ProductCategory { get; set; } //Produto e a categoria
    public string? SearchString { get; set; } // Pesquisar a categoria
}