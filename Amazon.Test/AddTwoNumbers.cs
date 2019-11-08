using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Amazon.Solutions;
using Xunit;

namespace Amazon.Test
{
    public class AddTwoNumbers
    {
        [Fact]
        public void Test()
        {
//            (2-> 4-> 3) +(5-> 6-> 4)
//            7-> 0-> 8
            var n1 = 342;
            var n2 = 465;
            var res = Solution.AddTwoNumbers(Save2List(n1), Save2List(n2));
            Assert.Equal(GetFromList(res), n1 + n2);
        }

        private ListNode Save2List(int num)
        {
            var head = new ListNode(0);
            var cur = head;

            while (num > 0)
            {
                var n = num % 10;
                cur.next = new ListNode(n);
                cur = cur.next;
                num /= 10;
            }

            return head.next;
        }

        private int GetFromList(ListNode list)
        {
            var sum = 0;
            var cnt = 0;
            while (list != null)
            {
                sum += list.val * (int) Math.Pow(10, cnt++);
                list = list.next;
            }

            return sum;
        }
    }
}