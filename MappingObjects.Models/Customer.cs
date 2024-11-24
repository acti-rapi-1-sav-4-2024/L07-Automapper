namespace MappingObjects.Models;

// Los objetos record son inmutables,
// lo que significa que no se pueden modificar después de que se crean. 
public record class Customer(
    string FirstName,
    string LastName
);