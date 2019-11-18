// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// GradeID:  D9817

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingParcelZip : Comparer<Parcel>
    {
        // Precondition: Two parcel class objects need to be passed in
        // Postcondition: Turns to descending order by destination zipcode
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;
            if (p1 == null)
                return -1;
            if (p2 == null)
                return 1;

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip);
        }
    }
}
