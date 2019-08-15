using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automato.Core
{
    public readonly struct Neighbours
    {
        private readonly Population _population;
        private readonly int _index;
        public Cell Left => _index > 0 ? _population.Cells[_index - 1] : Cell.Died;
        public Cell Cell => _population.Cells[_index];
        public Cell Right => _index < _population.Size - 1 ? _population.Cells[_index + 1] : Cell.Died;

        public Neighbours(Population population, int index)
        {
            _population = population;
            _index = index;
        }

        public bool IsValidRule(Rule rule)
            => rule.Left == Left && rule.Center == Cell && rule.Right == Right;
    }
}
