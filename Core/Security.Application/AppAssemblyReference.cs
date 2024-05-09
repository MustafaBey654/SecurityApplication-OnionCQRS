using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application
{
    public static  class AppAssemblyReference
    {
        public static readonly Assembly Assembly = typeof(Assembly).Assembly;
    }
}
