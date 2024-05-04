using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class Unit:EntityBase,IEntityBase
    {
        public string UnitName { get; set; }
        public int BranchId { get; set; }
        public  Branch Branch { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
