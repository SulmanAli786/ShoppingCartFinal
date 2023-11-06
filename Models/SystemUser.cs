using System;
using System.Collections.Generic;

namespace Shopping_Cart.Models
{
    public partial class SystemUser
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
