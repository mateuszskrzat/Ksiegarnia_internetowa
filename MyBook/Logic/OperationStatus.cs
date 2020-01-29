using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OperationStatus<T>
    {
        private bool _status;
        private Exception _error;
        private T _data;

        public bool Status { get => _status; set => _status = value; }
        public Exception Error { get => _error; set => _error = value; }
        public T Data { get => _data; set => _data = value; }

        public OperationStatus()
        {

        }
    }
}
