using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MsdRadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MsdRadixSort(IEnumerable<T> items) : base(items) { }

        public MsdRadixSort() { }

        protected override void MakeSort()
        {
            //SortCollection();

        }

        private void SortCollection(List<T> collection)
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength(collection);
            

            for (int step = 0; step < length; step++)
            {
                // Распределение элементов по корзинам.
                foreach (var item in collection)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, (step + 1)) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                collection.Clear();

                // Сборка элементов.
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        collection.Add(item);
                    }
                }

                // Очистка корзин.
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
            
        }

        private int GetMaxLength(List<T> collection)
        {
            var length = 0;
            foreach (var item in collection)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только натуральные числа", nameof(Items));
                }

                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); // Не дает работать с большими числами
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
