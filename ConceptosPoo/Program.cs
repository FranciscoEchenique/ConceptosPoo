// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Conceptos POO");
Console.WriteLine("=============");

Employee employe1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};

Employee employe2 = new ComissionEmployee()
{
    Id = 2020,
    FirstName = "Joaquín",
    LastName = "Gonzales",
    BirthDate = new Date(1994, 4, 22),
    HiringDate = new Date(2022, 2, 11),
    IsActive = true,
    Sales = 320123123M,
    ComissionPercentage = 0.03F
};

Console.WriteLine(employe2);


