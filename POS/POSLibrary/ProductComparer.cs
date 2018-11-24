using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    internal class ProductComparer : IEqualityComparer<TProductGroup>
    {
        public bool Equals(TProductGroup x, TProductGroup y)
        {
            return int.Equals(x.Barcode, y.Barcode);
        }

        public int GetHashCode(TProductGroup obj)
        {
            return obj.Barcode.GetHashCode();
        }
    }
}
