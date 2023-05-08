using System.Collections.Generic;
using System.Globalization;
using ExerciseFinal.Entities;

Console.Write("Entre com o caminho do arquivo:");
string path = Console.ReadLine();

Console.Write("Entre com o salario:");
double salaryPerson = double.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream) {
        string[] fields = sr.ReadLine().Split(",");
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

        list.Add(new Employee(name, email, salary));
    }
}

var emails = list.Where(e => e.Salary > salaryPerson).OrderBy(e => e.Email).Select(e => e.Email);
foreach (var item in emails) {
    Console.WriteLine(item);
}

var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
Console.WriteLine("Email of people whose salary is more than " + salaryPerson.ToString("F2", CultureInfo.InvariantCulture));