using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    enum ItemType{ Helm, Armor, Gloves, Boots, Weapon, Shield, Belt };

    internal class Item
    {
        private string _name = "Uknown";
        private double _cost = 25;
        private double _weigth = 30;
        public ItemType Type { get; set; }
        public string Name { get { return _name; } set { _name = value.Trim(); } }
        public double Cost { get { return _cost; } set { _cost = value; } }
        public double Weigth { get { return _weigth; } set { _weigth = value; } }

        public Item(string name, double cost, double weight, ItemType type)
        {
            Name = name;
            Cost = cost;
            Weigth = weight;
            Type = type;
        }
    }
}
