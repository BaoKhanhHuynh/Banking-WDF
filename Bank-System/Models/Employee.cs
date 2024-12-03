namespace Bank_System.Models
{
    public partial class Employee
    {
        public Employee() { }

    
        public string Id { get; set; } = string.Empty;
        public string Employee_Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
