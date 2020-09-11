using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Book(string _Name, int _Price)
        {
            Name = _Name;
            Price = _Price;
        }
    }
}
