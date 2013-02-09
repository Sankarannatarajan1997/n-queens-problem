using System.Collections.Generic;
using System.Windows.Forms;

namespace Visual_N_Queens_Solver
{
    class Solver
    {
        private int numberOfQueens;
        private InputForm.SolutionCallback solutionCallback;
        private int numberOfSolutions;

        public int Solve(int _numberOfQueens, InputForm.SolutionCallback _solutionCallback)
        {
            this.numberOfQueens = _numberOfQueens;
            this.solutionCallback = _solutionCallback;

            Board cleanBoard = new Board(_numberOfQueens);
            this.GoDeeper(cleanBoard, 1);

            return this.numberOfSolutions;
        }

        private void GoDeeper(Board currentBoard, int whichQueen)
        {
            List<int[]> safeSquares = currentBoard.GetFreeSquares(whichQueen);
            int numSafeSquares = safeSquares.Count;

            if ((numSafeSquares > 0) && (whichQueen < this.numberOfQueens))
            {
                foreach (int[] location in safeSquares)
                {
                    Board newBoard = currentBoard.Clone();
                    newBoard.PlaceQueen(location);

                    this.GoDeeper(newBoard, whichQueen + 1);
                }
            }
            else if ((numSafeSquares == 1) && (whichQueen == this.numberOfQueens))
            {
                List<int[]> locationInList = safeSquares;
                int[] location = locationInList[0];
                currentBoard.PlaceQueen(location);

                string formattedSolution = this.FormatSolution(currentBoard);
                this.solutionCallback(formattedSolution);
                this.numberOfSolutions++;
            }
            else
            {
                return;
            }
        }

        private string FormatSolution(Board board)
        {
            string formattedSolution = "";
            List<int[]> queenLocations = board.QueenLocations;

            foreach (int[] location in queenLocations)
            {
                char x = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[location[0]];
                int y = location[1] + 1;

                formattedSolution += string.Format("{0}{1} ", x, y);
            }

            return formattedSolution;
        }
    }
}
