using Automato.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = Automato.Core.Rule;

namespace Automato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            chkRule1.Checked = true;
            chkRule2.Checked = true;
            chkRule3.Checked = true;
            chkRule4.Checked = true;
        }
        public List<Rule> Rules = new List<Rule>();
        public const int MarginLeft = 20;
        public const int MarginTop = 50;
        private void Automata1()
        {
            Refresh();

            var graphicsObj = this.CreateGraphics();

            var cron = Stopwatch.StartNew();
            var iterations = new List<Population>();
            var population = new Population(1024);
            iterations.Add(population);

            for (int y = 0; y < population.Size / 2; y++)
            {
                population = population.ApplyRules(Rules.ToArray());
                iterations.Add(population);
            }

            Text = $"Time Generations: {cron.ElapsedMilliseconds}";

            population = Draw(graphicsObj, iterations, population);

            cron.Stop();

            Text += $" = Total: {cron.ElapsedMilliseconds}";
        }

        private static Population Draw(Graphics graphicsObj, List<Population> iterations, Population population)
        {
            for (int y = 0; y < population.Size / 2; y++)
            {
                population = iterations[y];
                for (int x = 0; x < population.Size; x++)
                {
                    if (population.Cells[x])
                        graphicsObj.FillRectangle(Brushes.Black, MarginLeft + x, MarginTop + y, 1, 1);
                };
            }

            return population;
        }

        private void ChkRules_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (sender as CheckBox);
            var index = Convert.ToInt32(checkbox.Tag);
            if (checkbox.Checked)
                Rules.Add(Rule.Rules[index]);
            else
                Rules.RemoveAll(w => w.Value == index);
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Automata1();
        }
    }
}
