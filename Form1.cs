﻿
using Algorithm;
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
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            addTextBox.Text = "";

            bubbleSortButton.Enabled = true;
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
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }

            fillTextBox.Text = "";
           
            bubbleSortButton.Enabled = true;
        }

        private void bubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwapEvent += Bubble_SwapEvent;
            bubble.Sort();
            bubbleSortButton.Enabled = false;
        }

        private void Bubble_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
            Thread.Sleep(50);
        }

        //private void Swap(SortedItem a, SortedItem b)
        //{
        //    a.SetColor(Color.Red);
        //    b.SetColor(Color.Green);
        //}
    }
}
