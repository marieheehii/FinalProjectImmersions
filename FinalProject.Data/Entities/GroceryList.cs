using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


    public class GroceryList
    {

        [Key]
        public int ID { get; set; }

        [Required]

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public DateTime DayofTrip { get; set; }

    }
