using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sort;

namespace oop_lab5_6_part_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            try
            {
                string str_in = TextBoxInput.Text;
                string[] str = str_in.Split(' ');
                int[] arr = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                    arr[i] = Convert.ToInt32(str[i]);

                switch (ChooseSort.SelectedIndex)
                {
                    case 0:
                        Sort_qSort(arr);
                        break;
                    case 1:
                        Sort_SelectionSort(arr);
                        break;
                    case 2:
                        Sort_HeapSort(arr);
                        break;
                    case 3:
                        Sort_ShellSort(arr);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Неправильно введены данные");
            }
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int count = Convert.ToInt32(TextBoxRandom.Text);
            TextBoxInput.Text = "";

            for (int i = 0; i < count; i++)
            {
                if (i+1 != count)
                    TextBoxInput.Text += r.Next(-100000, 100000).ToString() + ' ';
                else 
                    TextBoxInput.Text += r.Next(-100000, 100000).ToString();
            }

        }
        private void Sort_qSort(int[] arr) // .!.
        {
            qSort srt = new qSort();
            Stopwatch stopWatch = new Stopwatch();
            TextBoxOutput.Text = "";
            TextBoxTimeSort.Text = "";
            TextBoxCompare.Text = "";
            TextBoxAssignment.Text = "";
            stopWatch.Start();
            arr = srt.sort(arr);
            stopWatch.Stop();
            TextBoxTimeSort.Text = stopWatch.Elapsed.TotalSeconds.ToString();
            TextBoxAssignment.Text = srt.Assignment.ToString();
            TextBoxCompare.Text = srt.Compare.ToString();

            for (int i = 0; i < arr.Length; i++)
                TextBoxOutput.Text += Convert.ToString(arr[i]) + ' ';
        }

        private void Sort_SelectionSort(int[] arr)
        {
            SelectionSort srt = new SelectionSort();
            Stopwatch stopWatch = new Stopwatch();
            TextBoxOutput.Text = "";
            TextBoxTimeSort.Text = "";
            TextBoxCompare.Text = "";
            TextBoxAssignment.Text = "";
            stopWatch.Start();
            arr = srt.sort(arr);
            stopWatch.Stop();
            TextBoxTimeSort.Text = stopWatch.Elapsed.TotalSeconds.ToString();
            TextBoxAssignment.Text = srt.Assignment.ToString();
            TextBoxCompare.Text = srt.Compare.ToString();

            for (int i = 0; i < arr.Length; i++)
                TextBoxOutput.Text += Convert.ToString(arr[i]) + ' ';
        }

        private void Sort_HeapSort(int[] arr)
        {
            HeapSort srt = new HeapSort();
            Stopwatch stopWatch = new Stopwatch();
            TextBoxOutput.Text = "";
            TextBoxTimeSort.Text = "";
            TextBoxCompare.Text = "";
            TextBoxAssignment.Text = "";
            stopWatch.Start();
            arr = srt.sort(arr);
            stopWatch.Stop();
            TextBoxTimeSort.Text = stopWatch.Elapsed.TotalSeconds.ToString();
            TextBoxAssignment.Text = srt.Assignment.ToString();
            TextBoxCompare.Text = srt.Compare.ToString();

            for (int i = 0; i < arr.Length; i++)
                TextBoxOutput.Text += Convert.ToString(arr[i]) + ' ';
        }

        private void Sort_ShellSort(int[] arr)
        {
            ShellSort srt = new ShellSort();
            Stopwatch stopWatch = new Stopwatch();
            TextBoxOutput.Text = "";
            TextBoxTimeSort.Text = "";
            TextBoxCompare.Text = "";
            TextBoxAssignment.Text = "";
            stopWatch.Start();
            arr = srt.sort(arr);
            stopWatch.Stop();
            TextBoxTimeSort.Text = stopWatch.Elapsed.TotalSeconds.ToString();
            TextBoxAssignment.Text = srt.Assignment.ToString();
            TextBoxCompare.Text = srt.Compare.ToString();

            for (int i = 0; i < arr.Length; i++)
                TextBoxOutput.Text += Convert.ToString(arr[i]) + ' ';
        }
    }
}
