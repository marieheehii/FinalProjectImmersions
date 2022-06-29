using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class InventoryListItem
    {
     
        public int ID { get; set; }
        public string ItemsName { get; set; }
        public ItemCategory Category  { get; set; }
        public int Amount { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
