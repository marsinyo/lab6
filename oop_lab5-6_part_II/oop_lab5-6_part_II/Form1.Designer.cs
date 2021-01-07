namespace oop_lab5_6_part_II
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
            this.ChooseSort = new System.Windows.Forms.ComboBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.TextBoxTimeSort = new System.Windows.Forms.TextBox();
            this.TextBoxCompare = new System.Windows.Forms.TextBox();
            this.TextBoxAssignment = new System.Windows.Forms.TextBox();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.TextBoxRandom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseSort
            // 
            this.ChooseSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChooseSort.FormattingEnabled = true;
            this.ChooseSort.Items.AddRange(new object[] {
            "qSort",
            "Selection Sort",
            "HeapSort",
            "ShellSort"});
            this.ChooseSort.Location = new System.Drawing.Point(12, 147);
            this.ChooseSort.Name = "ChooseSort";
            this.ChooseSort.Size = new System.Drawing.Size(307, 24);
            this.ChooseSort.TabIndex = 0;
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(307, 95);
            this.TextBoxInput.TabIndex = 1;
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Location = new System.Drawing.Point(347, 12);
            this.TextBoxOutput.Multiline = true;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.Size = new System.Drawing.Size(307, 95);
            this.TextBoxOutput.TabIndex = 2;
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(12, 183);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(307, 45);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Start sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // TextBoxTimeSort
            // 
            this.TextBoxTimeSort.Location = new System.Drawing.Point(12, 271);
            this.TextBoxTimeSort.Multiline = true;
            this.TextBoxTimeSort.Name = "TextBoxTimeSort";
            this.TextBoxTimeSort.Size = new System.Drawing.Size(157, 28);
            this.TextBoxTimeSort.TabIndex = 4;
            // 
            // TextBoxCompare
            // 
            this.TextBoxCompare.Location = new System.Drawing.Point(256, 271);
            this.TextBoxCompare.Multiline = true;
            this.TextBoxCompare.Name = "TextBoxCompare";
            this.TextBoxCompare.Size = new System.Drawing.Size(157, 28);
            this.TextBoxCompare.TabIndex = 5;
            // 
            // TextBoxAssignment
            // 
            this.TextBoxAssignment.Location = new System.Drawing.Point(497, 271);
            this.TextBoxAssignment.Multiline = true;
            this.TextBoxAssignment.Name = "TextBoxAssignment";
            this.TextBoxAssignment.Size = new System.Drawing.Size(157, 28);
            this.TextBoxAssignment.TabIndex = 6;
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.Location = new System.Drawing.Point(347, 183);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(307, 45);
            this.ButtonRandom.TabIndex = 7;
            this.ButtonRandom.Text = "Random elements";
            this.ButtonRandom.UseVisualStyleBackColor = true;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // TextBoxRandom
            // 
            this.TextBoxRandom.Location = new System.Drawing.Point(347, 147);
            this.TextBoxRandom.Multiline = true;
            this.TextBoxRandom.Name = "TextBoxRandom";
            this.TextBoxRandom.Size = new System.Drawing.Size(307, 24);
            this.TextBoxRandom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(344, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество рандомных элементов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Метод сортировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время сортировки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(244, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество присваиваний";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(494, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество сравнений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxRandom);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.TextBoxAssignment);
            this.Controls.Add(this.TextBoxCompare);
            this.Controls.Add(this.TextBoxTimeSort);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ChooseSort);
            this.Name = "Form1";
            this.Text = "Сортировка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseSort;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.TextBox TextBoxTimeSort;
        private System.Windows.Forms.TextBox TextBoxCompare;
        private System.Windows.Forms.TextBox TextBoxAssignment;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.TextBox TextBoxRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

