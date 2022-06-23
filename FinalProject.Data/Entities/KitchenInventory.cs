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

        public ItemCategory Category  { get; set; }
        public int Amount { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
