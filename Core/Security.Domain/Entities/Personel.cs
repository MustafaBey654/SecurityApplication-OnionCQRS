using Microsoft.AspNetCore.Identity;
using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class Personel: IdentityUser<int>
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public ICollection<Unit> units { get; set; }
    }
}
