namespace HikersRealmAdmin.Components.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Difficulty { get; set; } = "Medium";
        public int MinDays { get; set; }
        public int MaxDays { get; set; }
        public int Length { get; set; }
        public string Status { get; set; } = "Inactive";
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Gpx { get; set; } = string.Empty;
        public List<Country> Countries { get; set; } = new();
        public List<Stage> Stages { get; set; } = new();
    }

}
