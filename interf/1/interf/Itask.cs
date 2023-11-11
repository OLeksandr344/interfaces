using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interf
{
    internal interface Itask
    {
        void Start();
        void Complete();
        string GetTaskInfo();
    }
}
