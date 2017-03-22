using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBasic.Models
{
    /// <summary>
    /// Уровень объекта из КЛАДР
    /// </summary>
    [Table("LocationLevel", Schema = "kladr")]
    public class LocationLevel
    {
        public int LocationLevelId { get; set; }

        [Required]
        public string LocationLevelName { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
