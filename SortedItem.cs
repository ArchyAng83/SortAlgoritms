using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoritms
{
    class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var x = number * 25;

            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 5);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(22, 120);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, 128);
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 25;
            ProgressBar.Location = new Point(x, 5);
            ProgressBar.Name = "ProgressBar" + number;
            Label.Location = new Point(x, 128);
            Label.Name = "label" + number;
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"object is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
