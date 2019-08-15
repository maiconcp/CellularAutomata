using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automato.Core
{
    public class Population
    {
        public int Size { get; }
        public Cell[] Cells { get; }

        public Population(int size)
        {
            Size = size;
            Cells = new Cell[Size];
            Cells[Size / 2] = true;
        }

        public Population(int size, params int[] initLiveIndex)
        {
            Size = size;
            Cells = new Cell[Size];
            foreach (var index in initLiveIndex)
            {
                Cells[index] = true;
            }            
        }

        public Population ApplyRules(Rule[] rules)
        {
            var newGeneration = new Population(Size);

            Parallel.For(0, Size, i =>
            {
                var neighbours = new Neighbours(this, i);

                newGeneration.Cells[i] = rules.Any(rule => neighbours.IsValidRule(rule));
            });

            return newGeneration;
        }
    }
}

