using System;
using System.Collections.Generic;

namespace ClientsCRM.Models
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Notes { get; set; }
    }
}
