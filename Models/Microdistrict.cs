﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBasic.Models
{
    /// <summary>
    /// Микрорайон
    /// </summary>
    [Table("Microdistrict", Schema = "dict")]
    public class Microdistrict
    {
        public int MicrodistrictId { get; set; }

        /// <summary>
        /// Наименование микрорайона
        /// </summary>
        [Required]
        public string MicrodistrictName { get; set; }

        /// <summary>
        /// Сокращённое наименование микрорайона
        /// </summary>
        [Required]
        public string MicrodistrictShortName { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public Location City { get; set; }

        /// <summary>
        /// Рекламные кампании клиентов с данным микрорайоном
        /// </summary>
        public ICollection<CampaignMicrodistricts> CampaignMicrodistricts { get; set; }

        /// <summary>
        /// Рекламные поверхности данного микрорайона
        /// </summary>
        public ICollection<Address> Addresses { get; set; }
    }
}
