namespace Assignment_3_C__Advanced
{
    public class Employee
    {
        public int id { set; get; }
        public string name { set; get; }
        public int age { set; get; }
        public string department { set; get; }
        public decimal salary { set; get; }
        public int grade { set; get; }

        public Employee(int id, string name, int age, string department, decimal salary, int grade)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
            this.salary = salary;
            this.grade = grade;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>//I generated these records using AI
            {
    new Employee(1, "Alice Smith", 28, "IT", 60000m, 3),
    new Employee(2, "Bob Johnson", 35, "HR", 55000m, 2),
    new Employee(3, "Charlie Brown", 42, "Finance", 75000m, 4),
    new Employee(4, "Diana Prince", 30, "IT", 65000m, 3),
    new Employee(5, "Ethan Hunt", 45, "Operations", 80000m, 5),
    new Employee(6, "Fiona Gallagher", 25, "Marketing", 48000m, 1),
    new Employee(7, "George Costanza", 38, "Sales", 52000m, 2),
    new Employee(8, "Hannah Abbott", 31, "HR", 58000m, 3),
    new Employee(9, "Ian Malcolm", 50, "Research", 90000m, 5),
    new Employee(10, "Julia Roberts", 29, "Marketing", 50000m, 2)
            };

            var q1 = employees.Select(a => a.salary *1.1m);
            var q2 = employees.OrderBy(a => a.age);
            var q3 = employees.OrderByDescending(a => a.salary);
            var q4 = employees.GroupBy(a => a.department).Select(a => new { Department = a.Key, Count = a.Count() });
            var q5 = employees.GroupBy(a => a.grade >= 80);



        }
    }
}
