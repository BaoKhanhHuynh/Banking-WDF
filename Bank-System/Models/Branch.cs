namespace Bank_System.Models
{
    public partial class Branch
    {
        public Branch() { }

        public Branch(string id, string name, string house_no, string city)
        {
            Id = id;
            Name = name;
            HouseNo = house_no;
            City = city;
        }

        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string HouseNo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
