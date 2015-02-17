using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewLibrary
{
    public class Catalog
    {

        private readonly Category[] categories;
        int currentIndex = 0;

        public Catalog()
        {
            categories = InitCategories();
        }

        private Category[] InitCategories()
        {
            var categories = new Category[] {

                new Category() { Title = "Desktops & Laptops", 
                                Description = "Latest desktops and laptops for all your personal computing needs", 
                                Image = "" },
                new Category() { Title = "Mobile", Description = "The sleekest mobile devices for computing on the go.", Image = "" },
                new Category() { Title = "Communication & Collaboration", Description = "Stay connected, whenever, wherever.", Image = "" },
                new Category() { Title = "Cloud Services", Description = "Safe, secure, always available.", Image = "" }
            };
             

            return categories;
        }

        public List<Category> GetCategories()
        {
            List<Category> values = new List<Category>();
            values.AddRange(categories);
            return values;
        }
    }
}
