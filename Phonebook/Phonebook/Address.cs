using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Address
    {
        public string brgy { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int number { get; set; }
        public string street { get; set; }
        public string zip { get; set; }

        public virtual void DisplayCompleteAdd() { }
    }
}
