﻿using System;

namespace Queues
{
    internal class Node
    {
        internal int value;
        internal Node next;
    }

    public class Queue
    {
        private Node head;
        private int size;

        public Queue() { }

        public void Enqueue(int n)
        {
            if (head == null) // queue is empty
            {
                head = new Node
                {
                    value = n,
                    next = null
                };
            }
            else // queue has items
            {
                var oldHead = head;
                head = new Node
                {
                    value = n,
                    next = oldHead
                };
            }
            size++;
        }

        public int? Dequeue()
        {
            if (size == 0)
                return null;

            var node = head;
            Node previous = node;
            while (node.next != null)
            {
                previous = node;
                node = node.next;
            }
            previous.next = null;
            size--;
            return node.value;
        }

        public int Count
        {
            get { return size; }
        }

        public string PrintElements()
        {
            var node = head;
            int[] elements = new int[size];
            int i = 0;
            while (node != null)
            {
                elements[i++] = node.value;
                node = node.next;
            }
            return string.Join(" ", elements);
        }
    }
}
