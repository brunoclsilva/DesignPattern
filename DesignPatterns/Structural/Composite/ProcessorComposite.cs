namespace DesignPatterns.Structural.Composite
{
    public class ProcessorComposite
    {
        public ProcessorComposite()
        {
            Component Pranaya = new Leaf("Pranaya", 22000);
            Component Rohit = new Leaf("Rohit", 33000);
            Component Anurag = new Leaf("Anurag", 42000);
            Component Priyanka = new Leaf("Priyanka", 52000);
            Component Sambit = new Leaf("Sambit", 28000);

            Composite ITDepartment = new Composite("ITDepartment");
            Composite HRDepartment = new Composite("HRDepartment");
            Composite Company = new Composite("Company");

            ITDepartment.AddComponent(Pranaya);
            ITDepartment.AddComponent(Rohit);
            ITDepartment.AddComponent(Anurag);

            HRDepartment.AddComponent(Priyanka);
            HRDepartment.AddComponent(Sambit);

            Company.AddComponent(ITDepartment);
            Company.AddComponent(HRDepartment);
            Console.WriteLine("All Employees of the Company");

            Console.WriteLine($"Total Salary of the Company: {Company.GetSalary()}");

            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {ITDepartment.GetSalary()}");

            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetSalary()}");

            Console.WriteLine("\nSalary of Employee Pranaya: ");
            Pranaya.GetSalary();
            Console.WriteLine($"\nSalary of Employee Anurag: ");
            Anurag.GetSalary();
        }
    }
}
