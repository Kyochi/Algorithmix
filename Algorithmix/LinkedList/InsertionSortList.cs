using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.LinkedList
{
    /*
     * Sort a linked list using insertion sort.
     */
    class InsertionSortList
    {
        public ListNode insertionSortList(ListNode A)
        {
            ListNode start = new ListNode(0);
            ListNode prec = start;
            ListNode cur = A;
            while (cur != null)
            {
                prec = start;

                while (prec.next != null && prec.next.val < cur.val)
                {
                    prec = prec.next;
                }
                ListNode n = cur.next;
                cur.next = prec.next;
                prec.next = cur;
                cur = n;
            }
            return start.next;
        }
    }
}
