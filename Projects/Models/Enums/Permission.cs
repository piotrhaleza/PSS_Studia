using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Flags]
    public enum Permission : byte
    {
        None = 0,
        All = 1,
        Write = 2,
        Add = 4,
    }
}
