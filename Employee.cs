namespace Exercisa.List.cSharp
{
    public class Employee
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; } = 1000;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee()
        {
        }

        public double increaseSalary(double percentage)
        {
            double result = Salary += Salary * percentage / 100.0;

            Console.WriteLine("Aumento Salarial: " + result);

            return result;
        }
    }
}
