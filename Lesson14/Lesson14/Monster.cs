using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    namespace Monster
    {
        enum MonsterType { Other, Goblinoid, Dragon, Construct, Undead, Beast, Abberation, MagicBeast, Energy, Fey };


        // Базовая реализация класса "Монстр" - так сказать, "в лоб".
        internal class Monster : Creature, ICombatan
        {
            private int hp = 500;
            private int min_attack;
            private int max_attack;

            private readonly string[] type_texts = { "другой", "гоблиноид", "дракон", "механизм", "нежить", "тварь", "мутант", "волшебная тварь", "энергетический", "фея" };
        private readonly Random random;

            public MonsterType Type { get; set; }       // авто-свойство
            
            public int HP
            {
                get { return hp; }
                set
                {
                    if (value > MaxHP) hp = MaxHP;
                    else if (value < 0) hp = 0;
                    else hp = value;
                }
            }

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

            public string WarCry { get; set; }
            public string DieCry { get; set; }

            public string TypeText
            {
                get { return type_texts[(int)Type]; }
            }
           
            public string Info
            {
                get
                {
                    return $"{Name}, тип: {TypeText}, здоровье: {HP}/{MaxHP} ({(IsDie ? "мертв" : "жив")}), " +
                    $"атака: {Min_attack}-{Max_attack}";
                }
            }

            public Monster(string name, MonsterType type, int max_hp, int min_attack, int max_attack)
                : base (name)
            {
                Name = name;
                Type = type;
                MaxHP = max_hp;
                HP = max_hp;
                Min_attack = min_attack;
                Max_attack = max_attack;
                random = new Random();
            }

            public Monster(string name, MonsterType type, int max_hp, int min_attack, int max_attack, string war_cry, string die_cry)
                : this(name, type, max_hp, min_attack, max_attack)
            {
                WarCry = war_cry;
                DieCry = die_cry;
            }

            public int GetAttack(int bonus)
            {
                return random.Next(Min_attack, Max_attack + 1) + bonus;
            }
            public void Atack(Creature creature)
            {
                creature.CurrentHp -= 20;
            }

            public override void Push(Creature creature)
            {
                creature.CurrentHp -= 20;
            }
        }
    }

}
