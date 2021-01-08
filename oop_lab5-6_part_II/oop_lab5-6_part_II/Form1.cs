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

namespace oop_lab5_6_part_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Sortings sort = null;

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            try
            {
                string str_in = TextBoxInput.Text;
                string[] str = str_in.Split(' ');
                int[] arr = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                    arr[i] = Convert.ToInt32(str[i]);

                sort = new SortingFactory().create(ChooseSort.SelectedIndex);
                Sort_arr(arr);
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

        private void Sort_arr(int[] arr)
        {
            if(sort == null)
            {
                MessageBox.Show("Неправильно введены данные");
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            TextBoxOutput.Text = "";
            TextBoxTimeSort.Text = "";
            TextBoxCompare.Text = "";
            TextBoxAssignment.Text = "";
            stopWatch.Start();
            arr = sort.sort(arr);
            stopWatch.Stop();
            TextBoxTimeSort.Text = stopWatch.Elapsed.TotalSeconds.ToString();
            TextBoxAssignment.Text = sort.Assignment.ToString();
            TextBoxCompare.Text = sort.Compare.ToString();

            for (int i = 0; i < arr.Length; i++)
                TextBoxOutput.Text += Convert.ToString(arr[i]) + ' ';
        }
    }
}
