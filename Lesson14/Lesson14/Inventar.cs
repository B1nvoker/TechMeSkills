using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Inventar: LinkedList<Item>
    {
        private string _owner = "Unknown";
        private int _size = 0;
        private int _maxSize = 500;

        public string Owner 
        { 
            get { return _owner; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                { 
                    throw new ArgumentNullException("У владельца должно быть имя!"); 
                }
                _owner = value.Trim();
            } 
        }
        public int Size 
        { 
            get { return _size; } 
            set 
            { 
                if(value > _maxSize)
                {
                    throw new ArgumentException("Неверное значение размера инвентаря!");
                }
                _size = value; } 
        }
        public int MaxSize 
        { 
            get { return _maxSize; } 
            set { _maxSize = value; } 
        }

        public Inventar(string owner)
        {
            Owner = owner;
        }
        public Inventar(string owner, int size, int maxSize)
        {
            Owner = owner;
            Size = size;
            MaxSize = maxSize;
        }
        public void AddItem(Item item)
        {
            if (Size == 0)
            {
                this.AddFirst(item);
                Size += item.Weigth;
            }
            else if (Size + item.Weigth <= MaxSize)
            {
                this.AddLast(item);
                Size += item.Weigth;
            }
            else
            {
                Console.WriteLine("Нет места в инвентаре");
            }
        }
        public void DeleteItem(Item item)
        {
            if (this.Remove(item))
            {
                Console.WriteLine($"Предмет {item.Name} удален из инвентаря");
            }
            else
            {
                Console.WriteLine($"Такого предмета нет в инвентаре");
            }
            
        }
    }
}
