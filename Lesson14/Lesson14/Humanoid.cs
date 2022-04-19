using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    enum HumanoidType { Other, Goblinoid, Dragon, Construct, Undead, Beast, Abberation, MagicBeast, Energy, Fey };

    internal class Humanoid : Creature
    {

        private int _intellect = 10;
        private Inventar _inventar;

        public HumanoidType Type { get; set; }
        public Inventar Inventar { get { return _inventar; } set { _inventar = value; } }
        public int Intelect { get { return _intellect; } set { _intellect = value; } }

        public Humanoid(string name, HumanoidType type)
            :base(name)
        {
            Type = type;
        }
        public override void Push(Creature creature)
        {
            creature.CurrentHp -= 20;
        }
    }
}
