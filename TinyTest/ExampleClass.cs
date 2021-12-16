using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyTest
{
    public class ExampleClass
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public ExampleClass(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
        }

        public virtual string Everything()
        {
            string str = "Name: " + name + ", ID; " + id.ToString();
            return str;
        }
    }
}
