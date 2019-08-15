using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automato.Core
{
    public readonly struct Cell
    {
        private readonly bool _value;

        public Cell(bool value)
        {
            _value = value;
        }

        public static implicit operator bool(Cell cell) => cell._value;
        public static implicit operator Cell(bool value) => new Cell(value);
        public static Cell Died => new Cell(false);
        public static Cell Live => new Cell(true);
        public override string ToString() => _value.ToString();
    }
}
