using Security.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Entities
{
    public class Branch:EntityBase,IEntityBase
    {
        public string BranchName {  get; set; }
        public ICollection<Unit> Units { get; set; }
        
    }
}
