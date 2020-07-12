
using Algorithm;
using Algorithm.DataStructers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoritms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();

            addTextBox.Text = "";
        }

        private void fillButton_Click(object sender, EventArgs e)
        {    
            var rnd = new Random();

            if (int.TryParse(fillTextBox.Text, out int value))
            {
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);                   
                }
            }

            RefreshItems();

            fillTextBox.Text = "";            
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            panel3.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }              

        private void BtnSortClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }

            panel3.Refresh();

            algorithm.CompareEvent += Algoritm_CompareEvent;
            algorithm.SwapEvent += Algoritm_SwapEvent;
            var time = algorithm.Sort();

            timeLabel.Text = "Время: " + time.Seconds;
            compareLabel.Text = "Количество сравнений: " + algorithm.ComprisonCount;
            swapLabel.Text = "Количество обменов " + algorithm.SwapCount;
        }

        private void Algoritm_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();
        }

        private void Algoritm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(50);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void baseSortButton_Click(object sender, EventArgs e)
        {
            var bases = new AlgorithmBase<SortedItem>(items);
            BtnSortClick(bases);
        }

        private void bubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnSortClick(bubble);
        }

        private void cocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnSortClick(cocktail);
        }

        private void insertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnSortClick(insert);
        }

        private void shellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnSortClick(shell);
        }

        private void selectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnSortClick(selection);
        }

        private void heapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            BtnSortClick(heap);
        }
    }
}
