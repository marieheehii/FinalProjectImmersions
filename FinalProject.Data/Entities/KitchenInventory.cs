using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


     public class KitchenInventory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string ItemsName { get; set; }
        [Required]
        public ItemCategory Category  { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
    }
