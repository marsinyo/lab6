using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5_6_part_II
{
    class SortingFactory
    {
        public Sortings create(int cd)
        {
            Sortings sh = null;
            switch (cd)
            {
                case 0:
                    sh = new qSort(); 
                    break;
                case 1:
                    sh = new SelectionSort(); 
                    break;
                case 2:
                    sh = new HeapSort(); 
                    break;
                case 3:
                    sh = new ShellSort();
                    break;
                default: break;
            }
            return sh;
        }
    }
}
