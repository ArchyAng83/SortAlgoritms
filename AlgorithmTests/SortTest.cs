using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.DataStructers;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> items = new List<int>();
        List<int> sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                items.Add(rnd.Next(0, 1000));
            }

            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x).ToArray());

        }

        [TestMethod()]
        public void BubbleSortTest()
        {
       
            //arrange
            var bubble = new BubbleSort<int>();           
            bubble.Items.AddRange(items);

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {

            //arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(items);

            //act
            cocktail.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], cocktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {

            //arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(items);

            //act
            insert.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {

            //arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(items);

            //act
            shell.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {

            //arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(items);

            //act
            bases.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bases.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {

            //arrange
            var tree = new TreeSort<int>();
            tree.Items.AddRange(items);

            //act
            tree.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], tree.Items[i]);
            }
        }

        //[TestMethod()]
        public void HeapSortTest()
        {

            //arrange
            var heap = new Heap<int>(items);

            //act
            heap.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], heap.Items[i]);
            }
        }


        [TestMethod()]
        public void SelectionSortTest()
        {
            //arrange
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(items);

            //act
            selection.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], selection.Items[i]);
            }
        }


        //[TestMethod()]
        public void GnomeSortTest()
        {

            //arrange
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(items);

            //act
            gnome.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], gnome.Items[i]);
            }
        }

        //[TestMethod()]
        public void LsdRadixSortTest()
        {

            //arrange
            var lsdRadix = new LsdRadixSort<int>();
            lsdRadix.Items.AddRange(items);

            //act
            lsdRadix.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], lsdRadix.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {

            //arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(items);

            //act
            merge.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {

            //arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(items);

            //act
            quick.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], quick.Items[i]);
            }
        }
    }
}
