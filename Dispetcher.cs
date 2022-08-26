using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._12._08
{
    public delegate void AddContent(Object content);
    internal class Dispatcher
    {
        public event AddContent? addContent;
        public event ArryaDelegat arryaDelegat;
        public event StringContains stringContains;
        public void AddObject(Object Content)
        {
            if (addContent != null)
            {
                addContent(Content);
            }
        }
        public List<int> SamplingFromArray(int[] arr)
        {
            if (arryaDelegat != null)
            {
                return arryaDelegat(arr);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public bool IsStringContaince(string str, string word)
        {
            if (stringContains != null)
            {
                return stringContains(str, word);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
