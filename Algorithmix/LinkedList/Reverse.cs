using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.LinkedList
{
    class Reverse
    {
        /*
         * Reverse a linked list
         */
        // recursive solution
        public ListNode reverseList(ListNode A)
        {
            ListNode resu = null;
            ListNode tete = null;
            Reverse.recurLink(ref resu, ref tete, A);
            return tete;
        }
        public static ListNode recurLink(ref ListNode res, ref ListNode tete, ListNode li)
        {
            if (li.next != null)
            {
                res = recurLink(ref res, ref tete, li.next);
                res.next = new ListNode(li.val);
                return res.next;
            }
            else
            {
                res = new ListNode(li.val);
                tete = res;
                return res;
            }
        }
    }
}
