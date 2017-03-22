using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBasic.Models
{
    [Table("CampaignMicrodistricts", Schema = "dbo")]
    public class CampaignMicrodistricts
    {
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }

        public int MicrodistrictId { get; set; }
        public Microdistrict Microdistrict { get; set; }
    }
}
