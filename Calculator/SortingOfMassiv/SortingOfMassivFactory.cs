using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOfMassiv
{
    static class SortingOfMassivFactory
    {
        public static ISorting CreateSorting(string operation)
        {
            switch (operation)
            {
                case "BubbleSorting":
                    return new BubbleSorting();
                    break;
                case "SelectionSorting":
                    return new SelectionSorting();
                    break;
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}