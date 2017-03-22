﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBasic.Models
{
    /// <summary>
    /// Форма оплаты размещения рекламы
    /// </summary>
    [Table("PaymentOrder", Schema = "dict")]
    public class PaymentOrder
    {
        public int PaymentOrderId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
        public string PaymentOrderName { get; set; }

        /// <summary>
        /// Рекалмные кампании
        /// </summary>
        public ICollection<Campaign> Campaigns { get; set; }
    }
}
