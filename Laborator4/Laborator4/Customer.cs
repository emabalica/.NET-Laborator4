using System;
using System.ComponentModel.DataAnnotations;

namespace Laborator4
{
    public class Customer
    {
        public Customer(string name, string adress, string phone, string email)
        {
            Id = new Guid();
            Name = name;
            Adress = adress;
            PhoneNumber = phone;
            Email = email;
        }

        public Guid Id { get; private set; }
        [Required] [StringLength(50)]public string Name { get; private set; }
        [Required] public string Adress { get; private set; }
        [Required] public string PhoneNumber { get; private set; }
        [Required] public string Email { get; private set; }
    }


}