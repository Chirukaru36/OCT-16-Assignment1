using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    class Smartphone:IComparable<Smartphone>
    {
        public string IMEINumber {  get; set; }
        public string Name { get; set; }

        public string Model { get; set; }

        public double Price {  get; set; }

        public int CompareTo(Smartphone other)
        {
            if (other == null)
            {
                return 1;
            }
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }
    }

    class SmartphoneNameComparer : IComparer<Smartphone>
    {
        public int Compare(Smartphone x, Smartphone y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Cannot compare null objects.");
            }
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}
