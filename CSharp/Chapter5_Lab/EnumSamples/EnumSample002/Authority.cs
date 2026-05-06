using System;
using System.Collections.Generic;
using System.Text;

namespace EnumSample002
{
    [Flags]
    public enum Authority
    {
        None = 0,
        Read = 1,
        Write = 2,
        Create = 4,
        Delete = 8
    }
}
