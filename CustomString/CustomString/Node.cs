using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class Node
    {
        public Char Data;
        public Node next;
        public Node(Char Data)
        {
            this.Data = Data;
            this.next = null;
        }
    }
}
