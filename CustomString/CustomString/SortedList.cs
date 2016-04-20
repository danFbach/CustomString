using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    [SerializableAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class SortedList : ICustomString
    {
        public void Insert(string stringToInsert, int index)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }

}
