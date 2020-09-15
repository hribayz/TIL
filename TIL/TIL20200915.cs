using System;
using System.Collections.Generic;
using System.Text;

namespace TIL
{
    // TIL that there is a collection called SortedSet<T>, which is something completely different to the SortedList<TKey,TValue> data structure.
    // If only had I known that half a year ago when interviewing at Trayport...
    class TIL20200915
    {
        public void DemonstrateSortedSet()
        {
            SortedSet<int> ss = new SortedSet<int>() { 3, 2, 3 };

            //SortedSet<int>(2) { 2, 3 }
            ss.Add(2); //false
            //SortedSet<int>(2) { 2, 3 }
            ss.Add(1); //true
            //SortedSet<int>(3) { 1, 2, 3 }
            ss.Remove(4); //false
            ss.Remove(2); //true
            //SortedSet<int>(2) { 1, 3 }
        }
    }
}
