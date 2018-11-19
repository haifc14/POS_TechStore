using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    internal class ProductComparer : IEqualityComparer<TProduct>
    {
        public bool Equals(TProduct x, TProduct y)
        {
            return int.Equals(x.Barcode, y.Barcode);
        }

        public int GetHashCode(TProduct obj)
        {
            return obj.Barcode.GetHashCode();
        }
    }
}
