using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class entryForm
    {
        public string Name { get; set; }
        //public -- always do get set
        //private just ;
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public entryForm()
        {
            Name = "";
            Address = string.Empty;
            //"" and string.Empty are same
            ZipCode = 0;
        }

        public entryForm(string name, string address, int zipCode)
        {
            Name = name;
            //creates row/object/instance
            Address = address;
            ZipCode = zipCode;

        }

        public override string ToString()
        {
            string entryForm = $"{Name} lives at {Address} {ZipCode}";
            return entryForm;
        }
    }
}
