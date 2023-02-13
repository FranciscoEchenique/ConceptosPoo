// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Conceptos POO");
Console.WriteLine("=============");

try
{ 
    Console.WriteLine(new Date(2022, 12, 10));
    Console.WriteLine(new Date(2022, 12, 12));
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2023, 2, 29));
}
catch(Exception error)
{
    Console.WriteLine(error.Message);
} 


