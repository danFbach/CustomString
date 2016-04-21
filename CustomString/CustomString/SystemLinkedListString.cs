using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class SystemLinkedListString : ICustomString
    {
        List<Char> charList = new List<char>() { 'r', 'a', 'p', 't', 'u', 'r', 'e' };
        public SystemLinkedListString()
        {

        }
        public void Insert(string stringToInsert, int index)
        {
            if (index.Equals(0))
            {
                Node head = new Node(stringToInsert[0]);
                Node curr = head;
                for (int j = 1; j < stringToInsert.Count(); j++)
                {
                    curr.next = new Node(stringToInsert[j]);
                    curr = curr.next;
                }
                for (int k = 0; k < charList.Count(); k++)
                {
                    curr.next = new Node(charList[k]);
                    curr = curr.next;
                }
                curr = head;
                while (curr != null)
                {
                    Console.Write(curr.Data);
                    curr = curr.next;
                }
            }
            else if (!index.Equals(0))
            {
                Node head = new Node(charList[0]);
                Node curr = head;
                for (int k = 1; k < charList.Count(); k++)
                {
                    if (k.Equals(index))
                    {
                        for (int j = 0; j < stringToInsert.Count(); j++)
                        {
                            curr.next = new Node(stringToInsert[j]);
                            curr = curr.next;
                        }
                    }
                    curr.next = new Node(charList[k]);
                    curr = curr.next;
                }
                
                curr = head;
                while (curr != null)
                {
                    Console.Write(curr.Data);
                    curr = curr.next;
                }
            }
        }

        public int Length()
    {
        int number = 0;
        //foreach(Char letter in linkedChars)
        //{
        //    number++;
        //}
        return number;
    }
    public void Remove(int startIndex, int numCharsToRemove)
    {

    }
}
}
