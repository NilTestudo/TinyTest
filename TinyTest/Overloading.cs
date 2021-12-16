using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyTest
{
    public class Overloading
    {
        public string Combine(string[] texts)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string t in texts)
            {
                sb.Append(t + ", ");
            }

            return sb.ToString();
        }

        public string Combine(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int n in numbers)
            {
                sb.Append(n + ", ");
            }

            return sb.ToString();
        }
    }
}
