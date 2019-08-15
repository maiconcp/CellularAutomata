using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automato.Core
{
    public readonly struct Rule
    {
        public int Value { get; }
        public Cell Left { get; }
        public Cell Center { get; }
        public Cell Right { get; }

        public static Rule[] Rules;
        private Rule(int id, Cell left, Cell center, Cell right)
        {
            Value = id;
            Left = left;
            Center = center;
            Right = right;
        }

        static Rule()
        {
            Rules = new Rule[8];

            Rules[0] = new Rule(0, false, false, false);
            Rules[1] = new Rule(1, false, false, true);
            Rules[2] = new Rule(2, false, true, false);
            Rules[3] = new Rule(3, false, true, true);
            Rules[4] = new Rule(4, true, false, false);
            Rules[5] = new Rule(5, true, false, true);
            Rules[6] = new Rule(6, true, true, false);
            Rules[7] = new Rule(7, true, true, true);
        }
    }
}
