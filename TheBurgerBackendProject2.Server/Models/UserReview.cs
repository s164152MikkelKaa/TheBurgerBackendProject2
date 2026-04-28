using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace TheBurgerBackendProject2.Server.Models
{
    [Supabase.Postgrest.Attributes.Table("UserReviews")]
    public class UserReview : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Supabase.Postgrest.Attributes.Column("spot_id")]
        public long SpotId { get; set; }

        [Supabase.Postgrest.Attributes.Column("user_id")]
        public string? UserId { get; set; }

        [Supabase.Postgrest.Attributes.Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Supabase.Postgrest.Attributes.Column("last_edit_at")]
        public DateTime? LastEditAt { get; set; }

        [Supabase.Postgrest.Attributes.Column("score")]
        public double? Score { get; set; }

        [Supabase.Postgrest.Attributes.Column("review_text")]
        public string? ReviewText { get; set; }

        [Supabase.Postgrest.Attributes.Column("picture_name")]
        public string? PictureName { get; set; }
    }
}
