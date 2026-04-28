using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBurgerBackendProject2.Server.Models
{
    [Supabase.Postgrest.Attributes.Table("BurgerSpots")]
    public class BurgerSpots : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Supabase.Postgrest.Attributes.Column("spot_name")]
        public string SpotName { get; set; }

        [Supabase.Postgrest.Attributes.Column("spot_address")]
        public string SpotAddress { get; set; }

        [Supabase.Postgrest.Attributes.Column("coordinate_lat")]
        public double CoordinateLat { get; set; }

        [Supabase.Postgrest.Attributes.Column("coordinate_lon")]
        public double CoordinateLon { get; set; }

        [Supabase.Postgrest.Attributes.Column("open_times")]
        public string? OpenTimes { get; set; }

        [Supabase.Postgrest.Attributes.Column("spot_score")]
        public double? SpotScore { get; set; }

        [Supabase.Postgrest.Attributes.Column("last_edit_at")]
        public DateTime? LastEditAt { get; set; }

        [Supabase.Postgrest.Attributes.Column("last_edit_by")]
        public string? LastEditBy { get; set; }

        [Supabase.Postgrest.Attributes.Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
