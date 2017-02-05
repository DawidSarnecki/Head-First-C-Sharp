using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGeneric_Ducks
{
    public enum SortKind
    {
        SizeThenkind,
        KindThenSize
    }

    public class ComplexDuckComparer : IComparer<Duck>
    {
        public SortKind SortBy = SortKind.KindThenSize;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortKind.SizeThenkind)
                if (x.Size < y.Size)
                    return -1;
                else if (x.Size > y.Size)
                    return 1;
                else
                    if (x.Kind < y.Kind)
                    return -1;
                else if (x.Kind > y.Kind)
                    return 1;
                else
                    return 0;
            else
                if (x.Kind < y.Kind)
                return -1;
            else if (x.Kind > y.Kind)
                return 1;
            else
                if (x.Size < y.Size)
                return -1;
            else if (x.Size > y.Size)
                return 1;
            else
                return 0;
        }
    }
}

