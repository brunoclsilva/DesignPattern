namespace DesignPatterns.Behavioral.Visitor
{
    public class ProcessorVisitor
    {
        public ProcessorVisitor()
        {
            var employees = new List<IVisitableElement>();

            Console.WriteLine("How many employees do you want to add?");
            Int32.TryParse(Console.ReadLine(), out int quantity);

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("What's the employe type? (1 - Backoffice, 2 - Sales)");
                Int32.TryParse(Console.ReadLine(), out int type);

                if(type == (int)EnumEmployeeType.Backoffice)
                {
                    var employee = GetEmployeeData(EnumEmployeeType.Backoffice);

                    employees.Add(new BackOfficeEmployee(employee.Name, employee.Salary, employee.Aditional));
                }
                else if(type == (int)EnumEmployeeType.Sales)
                {
                    var employee = GetEmployeeData(EnumEmployeeType.Sales);

                    employees.Add(new SalesEmployee(employee.Name, employee.Salary, employee.Aditional));
                }
                else
                {
                    throw new ArgumentException("Wrong employee type");
                }
            }

            // Calculating total compensation
            var compensationVisitor = new CompensationVisitor();

            employees.ForEach(e => e.Accept(compensationVisitor));
            Console.WriteLine($"Total compensation: {compensationVisitor.TotalCompensation:C}");

            // Calculating total stock options
            var esoVisitor = new EmployeeStockOptionVisitor();
            employees.ForEach(e => e.Accept(esoVisitor));

            Console.WriteLine($"Total stock: {esoVisitor.TotalUnit}");
        }

        public EmplyeeData GetEmployeeData(EnumEmployeeType type)
        {
            var aditional = type == EnumEmployeeType.Backoffice ? "bonus" : "commission";

            Console.WriteLine("Type the employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Type the salary: ");
            Decimal.TryParse(Console.ReadLine(), out decimal salary);

            Console.WriteLine($"Type the {aditional}: ");
            Decimal.TryParse(Console.ReadLine(), out decimal bonus);

            return new EmplyeeData() { Name = name, Salary = salary, Aditional = bonus };
        }
    }

    public class EmplyeeData
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Aditional { get; set; }
    }
}
