using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    interface IComparable<T>
    {
        int CompareTo(T other);
    }
}
