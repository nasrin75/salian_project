namespace salian_project.Models
{
    public class User
    {
        public long Id { get; set; }
        
        [Required(ErrorMessage ="مقدار این فیلد الزامی است.")]
		[MinLength(3,ErrorMessage ="حداقل طول این فیلد ۳ کاراکتر هست.")]
		[MaxLength(100,ErrorMessage = "حداکثر طول این فیلد ۳ کاراکتر هست.")]
        public required string Username { get; set; }

        [Required(ErrorMessage ="مقدار این فیلد الزامی است.")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "مقدار این فیلد الزامی است.")]
		[EmailAddress()]
        public string Email { get; set; }

        public string Mobile { get; set; }
        public  bool IsActive { get; set; }
    }
}
