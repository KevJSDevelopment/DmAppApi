using System.ComponentModel.DataAnnotations;

namespace DMApp.Dtos
{
    public class CharacterInitiateDto
    {
        public string? Name { get; set; }
        public string? Class { get; set; }
        public string? Race { get; set; }
        public string? Description { get; set; }
        public int? CampaignId { get; set; }
    }
}
