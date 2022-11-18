using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class MyClass
    {
        public static T Factory<T>() where T : new() => new();
    }
}
