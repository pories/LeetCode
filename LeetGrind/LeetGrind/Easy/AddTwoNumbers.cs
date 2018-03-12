using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    //Didn't test
    public static class AddTwoNumbers
    {
        //You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8



        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //public static class Solution{
        //    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //    {

        //        int carry = 0;
        //        ListNode newLn = new ListNode(0);
        //        ListNode root = newLn;

        //        while (l1 != null || l2 != null || carry == 1)
        //        {
        //            int l1val = 0;
        //            int l2val = 0;
        //            int sum = 0;

        //            if (l1 != null && l1.val != null)
        //                l1val = l1.val;

        //            if (l2 != null && l2.val != null)
        //                l2val = l2.val;

        //            sum = l1val + l2val + carry;

        //            if (carry == 1)
        //            {
        //                carry = 0;
        //            }

        //            if (sum > 9)
        //            {
        //                carry = 1;
        //                sum = sum % 10;
        //            }

        //            newLn.next = new ListNode(sum);
        //            newLn = newLn.next;

        //            if (l1 != null && l1.next != null)
        //                l1 = l1.next;
        //            else
        //                l1 = null;

        //            if (l2 != null && l2.next != null)
        //                l2 = l2.next;
        //            else
        //                l2 = null;
        //        }

        //        return root.next;
        //    }
        //}
        //}
        //try two
        public static ListNode AddingTwoNumbers1(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode dummy = new ListNode(0),
                     cur = dummy;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int val = carry;
                carry = 0;
                if (l1 != null)
                {
                    val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    val += l2.val;
                    l2 = l2.next;
                }

                if (val > 9)
                {
                    val -= 10;
                    carry = 1;
                }

                cur.next = new ListNode(val);
                cur = cur.next;
            }

            if (carry == 1)
            {
                cur.next = new ListNode(1);
            }

            return dummy.next;
        }
        //next one


        public static ListNode AddingTwoNumbers2(ListNode l1, ListNode l2)
        {
            var carry = 0;

            var dummy = new ListNode(-1);

            var cur1 = l1;
            var cur2 = l2;

            var cur = dummy;

            while (cur1 != null || cur2 != null)
            {
                var numberA = cur1 != null ? cur1.val : 0;
                var numberB = cur2 != null ? cur2.val : 0;

                var result = numberA + numberB + carry;

                var remainder = result % 10;

                carry = result / 10;

                cur.next = new ListNode(remainder);

                cur = cur.next;
                if (cur1 != null) cur1 = cur1.next;
                if (cur2 != null) cur2 = cur2.next;
            }

            if (carry != 0)
            {
                cur.next = new ListNode(carry);
            }

            var head = dummy.next;
            dummy.next = null;

            return head;
        }
        //next one
        public static ListNode AddingTwoNumbers3(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode tail = result;
            int digit = 0;

            while (l1 != null || l2 != null || digit != 0)
            {
                if (l1 != null)
                {
                    digit += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    digit += l2.val;
                    l2 = l2.next;
                }

                tail = tail.next = new ListNode(digit % 10);
                digit = digit > 9 ? 1 : 0;
            }

            return result.next;
        }

        //next one
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    int carrier = 0, tempResult = 0;
        //    ListNode dummyNode = new ListNode(-1), previousNode;
        //    previousNode = dummyNode;

        //    while (l1 != null || l2 != null)
        //    {
        //        if (l1 != null)
        //            tempResult += l1.val;

        //        if (l2 != null)
        //            tempResult += l2.val;

        //        if (carrier != 0)
        //        {
        //            tempResult += carrier;
        //            carrier = 0;
        //        }

        //        if (tempResult >= 10)
        //        {
        //            tempResult = tempResult % 10;
        //            carrier = 1;
        //        }

        //        previousNode.next = new ListNode(tempResult);
        //        previousNode = previousNode.next;

        //        tempResult = 0;
        //        if (l1 != null)
        //            l1 = l1.next;
        //        if (l2 != null)
        //            l2 = l2.next;
        //    }

        //says it beets most!
        // Definition for singly-linked list.
        //  public class ListNode
        //        {
        //     public int val;
        //     public ListNode next;
        //     public ListNode(int x) { val = x; }
        // }

        //public class Solution
        //        {
        //            int excess = 0;
        //            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //            {
        //                var local_l1 = l1;
        //                var local_l2 = l2;
        //                if (local_l1 != null || local_l2 != null)
        //                {
        //                    // if linked list has mismatching number of nodes, we "even them out" by replacing nulls with zeroes
        //                    int x = local_l1 != null ? local_l1.val : 0;
        //                    int y = local_l2 != null ? local_l2.val : 0;
        //                    int z = x + y;
        //                    if (excess > 0)
        //                    {
        //                        z += excess;
        //                        excess = 0;
        //                    }
        //                    if (z >= 10)
        //                    {
        //                        excess = 1;
        //                        z -= 10;
        //                    }
        //                    return new ListNode(z)
        //                    {
        //                        next = AddTwoNumbers(local_l1 == null ? null : local_l1.next, local_l2 == null ? null : local_l2.next)
        //                    };
        //                }
        //                if (excess > 0) return new ListNode(excess); else return null;
        //                // return excess value as next if only 1 node in any linked list 
        //            }
        //        
    }
}
