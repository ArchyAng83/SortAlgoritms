using Algorithm.DataStructers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class HeapSort<T> : Heap<T> where T: IComparable
    {
        public HeapSort(IEnumerable<T> items) : base(items) { }

        //public HeapSort() { }

        //protected override void MakeSort()
        //{
        //    var heap = new Heap<T>(Items);
        //    var sorted = heap.Order();
        //    Items = sorted;
        //}
    }
}
