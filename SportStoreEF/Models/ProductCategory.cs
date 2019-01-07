using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Models {
    public class ProductCategory {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ProductCategory(Product product, Category category) {
            Product = product;
            Category = category;
            ProductId = product.ProductId;
            CategoryId = category.CategoryId;
        }

        protected ProductCategory() {

        }
    }
}
