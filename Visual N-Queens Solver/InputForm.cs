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

namespace Visual_N_Queens_Solver
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (nQueensInput.Text.Length > 0)
            {
                solutionsList.Items.Clear();

                int nQueens = Int32.Parse(nQueensInput.Text.ToString());

                Solver solver = new Solver();

                string searchingMessage = string.Format(Strings.Searching, nQueens);
                this.OutputText(searchingMessage);
                this.OutputText("");
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                List<string> solutions = solver.Solve(nQueens);

                stopwatch.Stop();

                DisplaySolutions(solutions, stopwatch.Elapsed.TotalSeconds);
            }
        }

        private void DisplaySolutions(List<string> solutions, double timeTaken)
        {
            if (solutions.Count > 0)
            {
                foreach (string solution in solutions)
                {
                    OutputText(solution);
                }

                string foundMessage = string.Format(Strings.FoundSolutions, solutions.Count, timeTaken);
                this.OutputText("");
                this.OutputText(foundMessage);
            }
            else
            {
                string fNoSolutions = string.Format(Strings.NoSolutions, timeTaken);

                OutputText(fNoSolutions);
            }
        }

        private void OutputText(string item)
        {
            solutionsList.Items.Add(item);
        }

        private void nQueensInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
