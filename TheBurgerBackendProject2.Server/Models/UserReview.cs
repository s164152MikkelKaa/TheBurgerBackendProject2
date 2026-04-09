namespace TheBurgerBackendProject2.Server.Models
{
    public class UserReview
    {
        public int Id { get; set; }
        public int SpotId { get; set; }
        public string? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastEditAt { get; set; }
        public double? Score { get; set; }
        public string? ReviewText { get; set; }
        public string? PictureName { get; set; }
    }
}
