﻿/*
给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Amazon.Solutions
{
    public static partial class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0); //目标链表头结点
            var cur = head; //当前节点指针
            var carry = 0; //进位

            while (l1 != null || l2 != null)
            {
                var m = l1?.val ?? 0;
                var n = l2?.val ?? 0;

                var sum = m + n + carry;
                carry = sum / 10; //记录进位
                cur.next = new ListNode(sum % 10); //将当前位计算结果挂到当结果链表
                cur = cur.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
                cur.next = new ListNode(carry);

            return head.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) => val = x;
    }
}