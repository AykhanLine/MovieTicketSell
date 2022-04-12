using MovieTicketSell.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieTicketSell.SERVICE
{
    public class ProductService
    {
        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Film",
                Movie = "Dr.Strange in Multiverse of Madness",
                Category = "Sci-Fc",
                Price = 7,
                Description = "Wanda will be there",
                Hour = "11:00",
                Imbd = 9.5M

            },
            new Product
            {
                Id = 2,
                Name = "Film",
                Movie = "Scarlet Witch",
                Category = "Fantasy",
                Price = 8,
                Description = "Scarlet Witch discover her powers",
                Hour = "13:00",
                Imbd = 9.9M

            },
            new Product
            {
                Id = 3,
                Name = "Film",
                Movie = "Anabelle",
                Category = "Horror",
                Price = 5,
                Description = "So scarryy",
                Hour = "15:00",
                Imbd = 7.5M

            },
            new Product
            {
                Id = 4,
                Name = "Film",
                Movie = "Shameless",
                Category = "Comedy",
                Price = 6,
                Description = "You will be laugh",
                Hour = "18:00",
                Imbd = 9.5M

            },

        };
        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }
    }
}
