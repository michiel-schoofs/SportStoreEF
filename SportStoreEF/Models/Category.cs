using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class Category
    {
        #region Properties
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //Add property for products and initialize
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public IEnumerable<Product> Products => ProductCategories
            .Where(pc => pc.CategoryId == CategoryId)
            .Select(pc => pc.Product)
            .ToList();
        #endregion

        #region Constructor and Methods
        protected Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public Category(string name) : this()
        {
            Name = name;
        }


        public void AddProduct(string name, decimal price, string description, string thumbnail = null)
        {
            AddProduct((
                thumbnail==null?
                new Product(name, price, description):
                new OnlineProduct(name,price,thumbnail,description))
            );
        }

        public void AddProduct(Product product)
        {
            if(Products.Where(p=>p.Equals(product)).Count()==0)
                (ProductCategories as HashSet<ProductCategory>).Add(new ProductCategory(product, this));
        }

        public void RemoveProduct(Product product)
        {
            (ProductCategories as HashSet<ProductCategory>).Remove(
                (ProductCategories as HashSet<ProductCategory>).FirstOrDefault(pc=>pc.Product.Equals(product)
                ));
        }

        public Product FindProduct(string name)
        {
            return Products.FirstOrDefault(p => p.Name == name);
        }
        #endregion
    }
}
