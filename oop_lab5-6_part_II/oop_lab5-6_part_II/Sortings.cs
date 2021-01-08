using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5_6_part_II
{
    abstract class Sortings
    {
        public double Time { get; protected set; } = 0;
        public int Compare { get; protected set; } = 0; // сравнивание
        public int Assignment { get; protected set; } = 0; // присваивание

        abstract public int[] sort(int[] arr);
    }
}
