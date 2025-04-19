using System;
using System.ComponentModel.DataAnnotations;

namespace PantryApi.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int ItemQTY { get; set; }

        [DataType(DataType.Date)]
        public DateTime ItemBBDate { get; set; }
    }
}
