using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05UsingList
{
    //comparer interface is used to sort the values
    public class NoOfReadsComparator : IComparer<Story>
    {
       
        public int Compare(Story x, Story y)
        {
            return x.NoOfReads.CompareTo(y.NoOfReads);
        }
    }
}
