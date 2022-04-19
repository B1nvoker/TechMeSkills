using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal abstract class Creature
    {
        private string _name;
        private int _maxHp = 500;
        private int _currentHp = 500;

        public string Name {
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
        public int MaxHP {
            get { return _maxHp; }
            set { _maxHp = value; }
        }
        public int CurrentHp {
            get { return _currentHp; }
            set { _currentHp = value; }
        }
        public Creature(string name)
        {
            Name = name;
        }
        public bool IsDie
        {
            get { return CurrentHp == 0; }
        }
        public abstract void Push(Creature creature);
    }
}
