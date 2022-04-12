using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSell.MODELS
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Movie { get; set; }
        public int Price { get; set; }  
        public string Description { get; set; } 
        public string Category { get; set; }
        public  string Hour { get; set; }
        public decimal Imbd { get; set; }

    }
}
