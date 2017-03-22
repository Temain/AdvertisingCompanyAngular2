using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplicationBasic.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string FullName { get; set; }
    }
}
