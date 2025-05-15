namespace HikersRealmAdmin.Components.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public int StageNumber { get; set; }
        public string Start { get; set; } = "";
        public string End { get; set; } = "";
        public double Distance { get; set; }
        public int Ascent { get; set; }
        public int Descent { get; set; }
        public double Time { get; set; }
        public string Grade { get; set; } = "";
        public string Status { get; set; } = "Inactive"; // <-- Default value here
        public int TrailId { get; set; }
    }

}
