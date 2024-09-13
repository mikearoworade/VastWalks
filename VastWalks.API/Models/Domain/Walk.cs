namespace VastWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid DifficultyID { get; set; }
        public Guid RegionId { get; set; }
        //Navigation propertiess
        public Region Region { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
