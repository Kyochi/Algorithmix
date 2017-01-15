using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.LinkedList
{
    class Duplicate
    {
         /*
         * Given a sorted linked list, delete all duplicates such that each element appear only once.
         */
        public ListNode deleteDuplicates(ListNode A)
        {
            ListNode save = new ListNode(A.val);
            if (A.next == null) return save;
            ListNode current = A;
            ListNode sec = A.next;
            ListNode res = save;
            while (current != null && sec != null)
            {
                if (current.val == sec.val)
                {
                    sec = sec.next;
                }
                else
                {
                    current = sec;
                    save.next = new ListNode(current.val);
                    save = save.next;
                    sec = sec.next;
                }
            }
            return res;
        }
    }
}
