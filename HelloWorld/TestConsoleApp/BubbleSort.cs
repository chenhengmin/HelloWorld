using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class BubbleSort
    {
        public static List<int> Sort(List<int> sourceList)
        {
            for (int i = 0; i < sourceList.Count - 1; i++)
            {
                for (int j = 0; j < sourceList.Count - 1 - i; j++)
                {
                    if (sourceList[j] > sourceList[j + 1])
                    {
                        var temp = sourceList[j];
                        sourceList[j] = sourceList[j + 1];
                        sourceList[j + 1] = temp;
                    }
                }
            }
            return sourceList;
        }
    }
}
