using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Queue
    {
        private int head = 0;
        private int tail = 0;
        private int[] Q;
        
        public Queue(int Vondy)
        {
            Q = new int[Vondy];
        }

        public void enQueue(int num)
        {
            Q[tail] = num;
            tail++;
        }

        public int DeQueue()
        {
            head++;
            return Q[head];
        }
       
    }
}
