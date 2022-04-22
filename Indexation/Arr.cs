using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexation
{
    class Arr
    {
        private static readonly Random rnd = new Random();
        private static readonly Object mylock = new Object();
        public static int Getrandom(int min, int max)
        {
            lock (mylock)
            { return rnd.Next(min, max); }
        }
        public int[] array;
        public int begin;
        public int end;
        public int this[int index]
        {
            get
            {
                if (index + (-begin) >= 0 && index + (-begin) < array.Length)
                {
                    return array[index + (-begin)];
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Arr(int b, int e)
        {
            if (e < b)
            {
                begin = e;
                end = b;
            }
            else
            {
                begin = b;
                end = e;
            }
            int size = end - begin;

            array = new int[size];
            for (int i = 0; i < (end - begin); i++)
            {
                array[i] = Getrandom(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public override string ToString()
        {
            string str = " ";
            foreach (var item in array)
            {
                str += item;
            }
            return str;
        }
    }
}
