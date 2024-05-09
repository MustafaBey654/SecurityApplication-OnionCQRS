using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities.PersonelEntities
{
    public sealed class PersonelChartOfAccount:EntityBase
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public char PersonelType { get; set; } //komiser, polis Memuru
        public int PersonelId { get; set; }
    }
}
