using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN
{
    internal class film_info
    {
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
        }

        public List<Item> GetMockItems()
        {
            return new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Во власти стихий",
                    Description = "Description of Item 1",
                    ImageUrl = "https://cdn-st2.smotrim.ru/vh/pictures/vm/470/787/7.jpg",
                },
                new Item
                {
                    Id = 2,
                    Name = "Никита",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st1.smotrim.ru/vh/pictures/vm/475/649/2.jpg"
                },
                new Item
                {
                    Id = 3,
                    Name = "Разлом",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st1.smotrim.ru/vh/pictures/vm/470/802/0.jpg"
                },
            };
        }
    }
}
