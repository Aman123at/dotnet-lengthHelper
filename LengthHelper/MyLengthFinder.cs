using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthHelper
{

    // findLength Method to calculate length of string
    public  class MyLengthFinder
    {
        public int findLength(string s)
        {
            if (s == null)
                throw new NullReferenceException("String is null.");
            return s.Length;
        }
    }
}
