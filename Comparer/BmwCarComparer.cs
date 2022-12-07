using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer
{
    public class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar? x, BmwCar? y)
        {
            return string.Compare(x.Model, y.Model, StringComparison.Ordinal);
        }
    }
}
