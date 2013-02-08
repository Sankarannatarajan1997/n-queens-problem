using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_N_Queens_Solver
{
    class M2Solver
    {
        public List<string> Solve()
        {
            Board board = new Board();
        }

        private string FormatSolution(int[] boardState)
        {
            string formattedSolution = "";

            int file = 0;
            foreach (int rank in boardState)
            {
                formattedSolution += string.Format("{0}{1} ", this.ToLetter(file), rank + 1);
                file++;
            }

            return formattedSolution;
        }

        public char ToLetter(int index)
        {
            switch (index)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                default:
                    return 'x';
            }
        }
    }
}
