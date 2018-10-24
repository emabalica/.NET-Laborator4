using System;
using System.Linq;
namespace Laborator4

{
    public class CustomerRepository : ProductManagement
    {

        private void CreateCustomer(Customer customer)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                productManagement.CustomerSet.Add(customer);
                
            }
            
        }

        private void UpdateCustomer(Customer customer)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                productManagement.CustomerSet.Update(customer);
                productManagement.SaveChanges();
            }
        }

        private void DeleteCustomer(Guid id)
        {    
            
            using (ProductManagement productManagement = new ProductManagement())
            {
                Customer firstCustomer = productManagement.CustomerSet.First(p => p.Id == id);
                productManagement.CustomerSet.Remove(firstCustomer);
                productManagement.SaveChanges();
            }
        }
        private Customer GetById(Guid id)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                Customer firstCustomer = productManagement.CustomerSet.First(p => p.Id == id);
                return firstCustomer;
            }
        }

        private IQueryable<Customer> GetAllCustomers()
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                return productManagement.CustomerSet;
            }
        }

        private IQueryable<Customer> GetCustomerByEmail(string email)
        {
            using (ProductManagement productManagement = new ProductManagement())
            {
                return productManagement.CustomerSet.Where(p => p.Email == email);
                
            }
            
        }
    }
}