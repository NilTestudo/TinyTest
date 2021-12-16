using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyTest
{
    public class ExampleDerivedClass : ExampleClass
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public ExampleDerivedClass(int id, string name, string description = "") : base(id, name)
        {
            this.description = description;
        }

        public override string Everything()
        {
            string str = base.Everything() + " Description: " + Description;
            return str;
        }
    }
}
