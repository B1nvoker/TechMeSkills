using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal interface ICombatan
    {
        void Push(Creature creature);
        void Atack(Creature creature);

        int Min_attack { get; set; }
        int Max_attack { get; set; }

    }
}
