using System;
using System.Collections.Generic;

namespace Shopping_Cart.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Images { get; set; }
        public string? Quantity { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public string? Sku { get; set; }
        public int? CategoryId { get; set; }
        public string? Currency { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
