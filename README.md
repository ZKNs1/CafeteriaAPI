# Cafeteria ☕ - Backend C#

## Objetivos
- Gerenciar pedidos;
- Gerenciar estoque;
- Acompanhar vendas.

## Funcionalidades
- CRUD de pedidos e produtos;
- Filtragem de produtos por categoria e nome;
- Controle de estoque (atualização automática da quantidade de produtos após pedido);
- Geração de relatórios de pedidos.

---

## Estrutura MVC
A Cafeteria API segue o padrão MVC (Model-View-Controller), onde:
- **View**: Onde o usuário interage e as solicitações são direcionadas para o controller.
- **Controller**: Requisita os dados e ações do model, retornando o resultado da consulta.
- **Model**: Interage com o banco de dados fazendo consultas e inserções, devolvendo a resposta ao controller.

### Views
As views são responsáveis pela interação do usuário com a aplicação. Elas são responsáveis por exibir as telas.
- **Home**: Tela inicial;
- **Order**: Tela de pedidos;
- **Product**: Tela de estoque.

### Controllers
Os controllers são responsáveis por orquestrar as requisições e manipular os dados vindos do model. O fluxo é iniciado pela view que solicita uma ação ao controller, o qual por sua vez manipula os dados e retorna a resposta.
- **HomeController**: Controla a navegação entre as páginas, como a tela inicial e a privacidade.
- **OrderController**: Controla o CRUD dos pedidos (Create, Read, Update, Delete), lida com a criação de novos pedidos e o gerenciamento de estoque.
- **ProductController**: Controla o CRUD dos produtos no estoque, permitindo adicionar, editar, excluir e visualizar os produtos.

### Models
Os models interagem diretamente com o banco de dados para realizar operações de leitura e escrita.
- **Order**: Representa um pedido na cafeteria, incluindo informações sobre o pedido e o timestamp.
- **Product**: Representa um produto no estoque, com detalhes como nome, preço, quantidade e categoria.
- **ProductCategory**: Representa a categoria de um produto, ajudando a organizar o estoque por tipos de produtos.

---
``` Mermaid
classDiagram
    class Order {
        +int Id
        +DateTime TimeStamp
        +decimal TotalPrice
    }

    class OrderItem {
        +int Id
        +int IdOrder
        +int IdProduct
        +int Quantity
    }

    class Product {
        +int Id
        +string Name
        +int Quantity
        +string Category
        +decimal Price
    }

    class OrderCreateViewModel {
        +IEnumerable<SelectListItem> ProductsSelectList
        +IEnumerable<Product> Products
        +decimal TotalPrice
        +string Message
    }

    class ProductCategoryViewModel {
        +SelectList Categories
        +IEnumerable<Product> Products
    }

    class CafeteriaContext {
        +DbSet<Order> Orders
        +DbSet<OrderItem> OrderItems
        +DbSet<Product> Products
    }
```
