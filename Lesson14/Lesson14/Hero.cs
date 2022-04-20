using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class Hero : Humanoid, ICombatan
    {
        private int min_attack;
        private int max_attack;

        public int Min_attack
        {
            get { return min_attack; }
            set
            {
                if (value < 1 || value > 10)
                    throw new ArgumentException("Неверное значение мин. атаки!");
                min_attack = value;
            }
        }
        public int Max_attack
        {
            get { return max_attack; }
            set
            {
                if (value < 20 || value > 100)
                    throw new ArgumentException("Неверное значение макс. атаки!");
                max_attack = value;
            }
        }

        public Hero(string name, HumanoidType type) : base(name, type)
        {
            Name = name;
            Type = type;
            Min_attack = min_attack;
            Max_attack = max_attack;
        }

        public void Atack(Creature creature)
        {
            creature.CurrentHp -= 20;
        }
    }
}
