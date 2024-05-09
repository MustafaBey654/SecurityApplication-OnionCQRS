using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence
{
    public static class MyAssemblyReference
    {
        public static readonly Assembly Assembly = typeof(Assembly).Assembly;
    }
}
