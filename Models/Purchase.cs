using System;
using System.Collections.Generic;

namespace Shopping_Cart.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? DateOfPurchased { get; set; }
        public string? VendorName { get; set; }
    }
}
