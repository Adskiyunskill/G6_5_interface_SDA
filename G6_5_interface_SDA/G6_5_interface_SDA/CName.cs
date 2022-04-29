using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_5_interface_SDA
{
    class CName : IComparer<Company>
    {
        public int Compare(Company x, Company y)
        {
            if (String.Compare(x.Name,
            y.Name, true) > 0)
                return 1;
            else
            if (String.Compare(x.Name,
            y.Name, true) < 0)
                return -1;
            else return 0;
        }
    }
}
