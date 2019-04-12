using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OperationStatus
    {
        public Operation Operation { get; set; }
        public Status Status { get; set; }
        public string ErrorMessage { get; set; }

        public static implicit operator Task<object>(OperationStatus v)
        {
            throw new NotImplementedException();
        }
    }
}
