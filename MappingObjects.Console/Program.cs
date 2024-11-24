// See https://aka.ms/new-console-template for more information

using AutoMapper;
using MappingObjects.Mappers;
using MappingObjects.Models;

Cart cart = new(
    Customer: new(
        FirstName: "Kevin",
        LastName: "Hernandez"),
    Items: new()
    {
        //500 * 10 = 5000
        new(ProductName: "Manzanas", UnitPrice: 500, Quantity: 10),
        //50 * 4 = 200
        new(ProductName: "Bananos", UnitPrice: 50, Quantity: 4),
        //Fullname: Kevin Hernandez
        //Total: 5000 + 200 = 5200
    }
);

Console.WriteLine("=== Cart Original ===");
Console.WriteLine($"{cart.Customer}");

foreach (LineItem lineItem in cart.Items)
{
    Console.WriteLine($"{lineItem.ProductName} - {lineItem.UnitPrice} - {lineItem.Quantity}");
}


MapperConfiguration configuration = CartToSummaryMapper.GetMapperConfiguration();
IMapper mapper = configuration.CreateMapper();

Summary summary = mapper.Map<Cart, Summary>(cart);

Console.WriteLine();
Console.WriteLine("=== Summary después del mapeo ===");
Console.WriteLine($"Summary: {summary.FullName} gastó {summary.Total} en su compra");