// Let's call Employee
using UI;

Employee emp = new Employee();
//emp.firstName = "Mark";
//emp.lastName = "Fonseca";

// Employee.planet = "Mars"; // const can never be changed

Console.WriteLine("Please enter first name ");
var firstName=Console.ReadLine();
Console.WriteLine("Please enter last name ");
var lastName = Console.ReadLine();
Console.WriteLine("Please enter employee ID ");
var id = Console.ReadLine();
Console.WriteLine("Please submit working hours ");
var hours = Convert.ToDouble(Console.ReadLine());

emp.DoTask("Sheen", "Joseph", "298", 7);

//Console.WriteLine($"Employee Id - {emp.id}\nEmployee Name {emp.firstName} {emp.lastName}\nPlanet {Employee.planet}");

Manager mgr = new Manager();
mgr.authority = Authority.Hire;
Console.WriteLine(mgr.GetDetails("David", "Fay", "303",45));