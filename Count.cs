using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day_1_opg1
{
    public class Count
    {
        public int counter;

        public int WordCounter(string maintext, string wordcount)
        {
            string[] splittext = maintext.ToLower().Split(' ');

            foreach (string word in splittext)
            {
                if (word.Contains(wordcount.ToLower()))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
