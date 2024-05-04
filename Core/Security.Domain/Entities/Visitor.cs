using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class Visitor :EntityBase,IEntityBase
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CarPlateName { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public DateTime? ReleaseDate { get; set; }
        public bool JobInterview { get; set; } = true;
        public bool Visit { get; set; } = false;

        public int? BranchId { get; set; }
        public int? UnitId { get; set; }
        public int personelId { get; set; }
        public Personel Personel { get; set; }
    }
}
