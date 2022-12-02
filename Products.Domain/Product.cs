using System;

namespace Products.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Amount { get; set; }
        public DateTime DateReceipt { get; set; }
    }
}