using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedproject3
{
    public class queuedemo
    {
        static void Main(string[] args)
        {
            RunApp();
        }




        public class Queue
        {
            private int[] ele;
            private int front;
            private int rear;
            private int max;

            public Queue(int size)
            {
                ele = new int[size];
                front = 0;
                rear = -1;
                max = size;
            }

            public void insert(int item)
            {
                if (rear == max - 1)
                {
                    return;
                }
                else
                {
                    ele[++rear] = item;
                }
            }

            public int delete()
            {
                if (front == rear + 1)
                {
                    return -1;
                }
                else
                {
                    return ele[front++];
                }
            }

            public string printQueue()
            {
                string retVal = "";
                if (front == rear + 1)
                {
                    return retVal;
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        retVal += ele[i] + " ";
                    }
                }
                return retVal;
            }
            static void Main(string[] args)
            {
                RunApp();
            }
        }
            public static void RunApp()
            {
                Queue Q = new Queue(10);

                Q.insert(10);
                Q.insert(20);
                Q.insert(30);
                Q.insert(40);
                Q.insert(50);
                Q.insert(60);
                Q.insert(70);
                Q.insert(80);
                Q.insert(90);
                Q.insert(100);

                Console.WriteLine(Q.printQueue());

                Q.delete();
                Q.delete();

                Console.WriteLine(Q.printQueue());
                Console.ReadLine();
            }


        }
    }



