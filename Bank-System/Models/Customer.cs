namespace Bank_System.Models
{
    public partial class Customer
    {
        public Customer() { }

        public Customer(string id, string name, string phone, string email, string houseNo, string city, string pin)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            HouseNo = houseNo;
            City = city;
            Pin = pin;
        }

        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HouseNo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Pin { get; set; } = string.Empty;
    }
}
