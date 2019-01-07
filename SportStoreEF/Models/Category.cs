using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class Category
    {
        #region Properties
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; private set; }
        #endregion


        #region Constructor and Methods
        protected Category()
        {
            Products = new List<Product>();
        }

        public Category(string name) : this()
        {
            Name = name;
        }
        #endregion
    }
}
