using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._12._08
{
    internal class ArrayInt
    {
        public int Length { get; set; }
        private int _position;
        public int Position { get { return _position; } set { _position = value; } }
        public int[] TestArr;
        public ArrayInt(int Length)
        {
            TestArr = new int[Length];
        }
        public void FillRandom(int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < TestArr.Length; i++)
            {
                TestArr[i] = rnd.Next(Max);
            }
        }
        public void FillNegative(int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < TestArr.Length; i++)
            {
                TestArr[i] = -1 * rnd.Next(Max);
            }
        }
        public void Show()
        {
            foreach (int i in TestArr)
            {
                Console.Write($" {i}");
            }
        }
    }
}