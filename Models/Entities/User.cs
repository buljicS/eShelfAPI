namespace eShelfAPI.Models.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } 
        public string UserEmail { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
