using System;
using System.Collections.Generic;

namespace Shopping_Cart.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int? SystemUserId { get; set; }
        public string? Purchased { get; set; }
        public string Status { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
