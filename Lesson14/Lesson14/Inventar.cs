using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Inventar
    {
        private string _owner = "Unknown";
        private double _size = 0;
        private double _maxSize = 500;

        public string Owner { get { return _owner; } set { _owner = value.Trim(); } }
        public double Size { get { return _size; } set { _size = value; } }
        public double MaxSize { get { return _maxSize; } set { _maxSize = value; } }

        LinkedList<Item> Items = new LinkedList<Item>();

        public Inventar(string owner, double size, double maxSize)
        {
            Owner = owner;
            Size = size;
            MaxSize = maxSize;
            Items = new LinkedList<Item>();
        }
    }
}
