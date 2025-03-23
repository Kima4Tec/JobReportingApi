namespace JobReportingApi.Models
{
    public class Companies
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? CompanySize { get; set; }
        public string Creating { get; set; } = string.Empty;
        public string Facts { get; set; } = string.Empty;
        public string Offering { get; set; } = string.Empty;
        public string CompanyOffer { get; set; } = string.Empty;
        public string Motivation { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
