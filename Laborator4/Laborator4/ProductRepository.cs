using System;
using System.Linq;

namespace Laborator4
{
    public class ProductRepository
    {

        private void CreateProduct(Product product)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                productManagement.Products.Add(product);
            }
        }

        private void UpdateProduct(Product product)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                productManagement.Products.Update(product);
                productManagement.SaveChanges();
            }
        }

        private void DeleteProduct(Guid id)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                Product firstProd = productManagement.Products.First(p => p.Id == id);
                productManagement.Products.Remove(firstProd);
                productManagement.SaveChanges();
            }
        }

        private Product GetById(Guid id)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                return  productManagement.Products.First(p => p.Id == id);
                
            }
        }
        
        private IQueryable<Product> GetAllProducts()
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                return productManagement.Products;
            }
        }

        private IQueryable<Product> GetProductsById(Guid id)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                return productManagement.Products.Where(p => p.Id == id);
                
            }
            
        }
    }
}