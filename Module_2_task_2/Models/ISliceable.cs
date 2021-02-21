using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models
{
    public interface ISliceable<T>
    {
        T Slice();
    }
}
