using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public enum Status
    {
        Error,
        Success,
        Failed
    }

    public enum Operation
    {
        Create,
        Read,
        Update,
        Delete
    }
}
