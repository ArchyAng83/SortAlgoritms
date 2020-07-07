namespace SortAlgoritms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fillButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.compareLabel = new System.Windows.Forms.Label();
            this.swapLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 71);
            this.panel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(198, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить число";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(13, 27);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(179, 22);
            this.addTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fillButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fillTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 71);
            this.panel2.TabIndex = 1;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(199, 25);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Заполнить";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заполнение случайными числами";
            // 
            // fillTextBox
            // 
            this.fillTextBox.Location = new System.Drawing.Point(13, 27);
            this.fillTextBox.Name = "fillTextBox";
            this.fillTextBox.Size = new System.Drawing.Size(180, 22);
            this.fillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(301, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 147);
            this.panel3.TabIndex = 2;
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(12, 182);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(75, 23);
            this.bubbleSortButton.TabIndex = 3;
            this.bubbleSortButton.Text = "BubbleSort";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 212);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Время:";
            // 
            // compareLabel
            // 
            this.compareLabel.AutoSize = true;
            this.compareLabel.Location = new System.Drawing.Point(12, 235);
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(133, 13);
            this.compareLabel.TabIndex = 5;
            this.compareLabel.Text = "Количество сравнений:";
            // 
            // swapLabel
            // 
            this.swapLabel.AutoSize = true;
            this.swapLabel.Location = new System.Drawing.Point(10, 257);
            this.swapLabel.Name = "swapLabel";
            this.swapLabel.Size = new System.Drawing.Size(123, 13);
            this.swapLabel.TabIndex = 6;
            this.swapLabel.Text = "Количество обменов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 407);
            this.Controls.Add(this.swapLabel);
            this.Controls.Add(this.compareLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label compareLabel;
        private System.Windows.Forms.Label swapLabel;
    }
}

