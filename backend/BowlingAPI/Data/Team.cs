using System.ComponentModel.DataAnnotations;

namespace BowlingAPI.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public required string TeamName { get; set; }
        public int? CaptainID { get; set; }
    }
}