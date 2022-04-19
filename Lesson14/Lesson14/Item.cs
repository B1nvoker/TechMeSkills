using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    enum ItemType { Helm, Armor, Gloves, Boots, Weapon, Shield, Belt };

    internal class Item
    {
        private string _name = "Uknown";
        private int _cost = 0;
        private int _weigth = 0;
        public ItemType Type { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("У предмета должно быть имя!");
                }  
                _name = value.Trim();
            }
        }
        public int Cost { get { return _cost; } set { _cost = value; } }
        public int Weigth
        {
            get { return _weigth; }
            set
            {
                if (value < 0 || value > 500)
                { 
                    throw new ArgumentException("Неверное значение максимального веса!"); 
                }
                _weigth = value;
            }
        }

        public Item(string name, int cost, int weight, ItemType type)
        {
            Name = name;
            Cost = cost;
            Weigth = weight;
            Type = type;
        }
    }
}
