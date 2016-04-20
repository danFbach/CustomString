using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class SystemLinkedListString : ICustomString
    {
        Char[] chars =
        {'r', 'a', 'p', 't', 'u', 'r', 'e'};
        LinkedList<Char> linkedChars;
        public SystemLinkedListString()
        {
            linkedChars = new LinkedList<Char>(chars);
        }
        public void Insert(string stringToInsert, int index)
        {

        }
        public int Length()
        {
            int number = 0;
            foreach(Char letter in linkedChars)
            {
                number++;
            }
            return number;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            
        }
    }
}
