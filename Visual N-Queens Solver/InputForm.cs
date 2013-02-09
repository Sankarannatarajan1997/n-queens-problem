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
                this.Cursor = Cursors.WaitCursor;

                solutionsList.Items.Clear();

                int nQueens = Int32.Parse(nQueensInput.Text.ToString());

                SolutionCallback solutionCallback = new SolutionCallback(this.OutputText);

                Solver solver = new Solver();

                string searchingMessage = string.Format(Strings.Searching, nQueens);
                this.OutputText(searchingMessage);
                this.OutputText("");
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int numberOfSolutions = solver.Solve(nQueens, solutionCallback);

                stopwatch.Stop();

                string finalMessage = string.Format(Strings.FoundSolutions, numberOfSolutions, stopwatch.Elapsed.TotalSeconds);
                this.OutputText("");
                this.OutputText(finalMessage);

                this.Cursor = Cursors.Default;
            }
        }

        public delegate void SolutionCallback(string solution);

        private void OutputText(string item)
        {
            solutionsList.Items.Add(item);
            solutionsList.Update();
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
