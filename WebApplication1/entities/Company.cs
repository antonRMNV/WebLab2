namespace WebApplication1.entities
{
    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public Company()
        {
            Name = "Default";
            Employees = 0;
        }

        public Company(string name, int employees)
        {
            Name = name;
            Employees = employees;
        }

        public override string ToString()
        {
            return "Company: " + Name + " has " + Employees + " employees";
        }
    }
}

