namespace salian_project.Models
{
    public class User
    {
        public long Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public  bool IsActive { get; set; }
    }
}
