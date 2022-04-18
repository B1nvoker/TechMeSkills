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
        private string[] type_texts = { "другой", "гоблиноид", "дракон", "механизм", "нежить", "тварь", "мутант", "волшебная тварь","энергетический", "фея" };
        private int _intellect;

        private Inventar _inventar;
        
        public HumanoidType Type { get; set; }


        public override int push()
        {
            throw new NotImplementedException();
        }
    }
}
