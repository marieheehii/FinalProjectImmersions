using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Customer
    {
       
       [key]
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
