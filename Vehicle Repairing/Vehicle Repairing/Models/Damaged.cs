using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Repairing.Models
{
    public class Damaged
    {
        [Key]
        public int DamagedId { get; set; }

        [Required]
        public string ItemName { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        // Foreign Key ke Client
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
