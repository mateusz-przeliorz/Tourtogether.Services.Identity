using System;

namespace Tourtogether.Services.Identity.Core.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCreated { get; set; }
    }
}
