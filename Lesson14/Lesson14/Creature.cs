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
        private int _maxHp;
        private int _currentHp;

        public bool _isDie
        {
            get { return CurrentHp == 0; }
        }

        public int CurrentHp { get; set; }
        public abstract int push();
    }
}
