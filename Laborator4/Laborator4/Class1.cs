using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Laborator4
{
    public class Product

    {
        public Product(string N, string description, DateTime Sd, DateTime Ed, int p, int V)
        {
            Id=new Guid();
            //Name=N.Substring(0, Math.Min(50, N.Length));
            Name = Name;
            startDate = Sd;
            price = p;
            VAT = V;
            endDate = Ed;
            Description = description;

        }
        public Guid Id { get;private set; }
        [Required] [StringLength(50)]  public string Name {get; private set;}
        [Required] public string Description { get; private set; }
        [Required] public DateTime startDate { get; private set; }
        [Required] public DateTime endDate { get;private set; }
        [Required] public int price { get; private set; }
        [Required] public int VAT { get;private set; }
        public double computeVAT()
        {
            double v;
            v = price * VAT / 100;
            return v;
        }
    }
}