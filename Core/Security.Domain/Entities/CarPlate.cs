using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class CarPlate:EntityBase,IEntityBase
    {
        public string PlateName { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public bool IsPersonel { get; set; } = false;

    }
}
