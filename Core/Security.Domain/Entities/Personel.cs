using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class Personel:EntityBase,IEntityBase
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public ICollection<Unit> units { get; set; }
    }
}
