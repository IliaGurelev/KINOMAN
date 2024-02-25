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
                    Name = "Во власти стихии",
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
                new Item
                {
                    Id = 4,
                    Name = "Идеальная няня",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st1.smotrim.ru/vh/pictures/vm/463/918/8.jpg"
                },
                new Item
                {
                    Id = 5,
                    Name = "Эйфель",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st3.smotrim.ru/vh/pictures/vm/468/675/4.jpg"
                },
                new Item
                {
                    Id = 6,
                    Name = "Девять жизней",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st4.smotrim.ru/vh/pictures/vm/468/715/9.jpg"
                },
                new Item
                {
                    Id = 7,
                    Name = "Чебурашка",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st1.smotrim.ru/vh/pictures/vm/471/207/2.jpg"
                },
                new Item
                {
                    Id = 8,
                    Name = "Последний богатырь",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st1.smotrim.ru/vh/pictures/vm/468/587/2.jpg"
                },
                new Item
                {
                    Id = 9,
                    Name = "На линии огня",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st2.smotrim.ru/vh/pictures/vm/473/330/1.jpg"
                },
                new Item
                {
                    Id = 10,
                    Name = "Я на перемотке",
                    Description = "Description of Item 2",
                    ImageUrl = "https://cdn-st3.smotrim.ru/vh/pictures/vm/468/261/8.jpg"
                },
            };
        }
    }
}
