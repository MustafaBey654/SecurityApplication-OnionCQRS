using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class BranchAndUnitRelationShip: EntityBase,IEntityBase
    {
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        public int? UnitId { get; set; }
        public Unit? Unit { get; set; }


    }
}
