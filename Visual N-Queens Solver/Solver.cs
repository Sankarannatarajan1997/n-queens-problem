using System.Collections.Generic;
using System.Windows.Forms;

namespace Visual_N_Queens_Solver
{
    class Solver
    {
        private int numberOfQueens;
        private List<string> solutions;

        public List<string> Solve(int _numberOfQueens)
        {
            this.numberOfQueens = _numberOfQueens;
            Board cleanBoard = new Board(_numberOfQueens);
            this.solutions = new List<string>();

            this.GoDeeper(cleanBoard, 1);

            return this.solutions;
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

                this.solutions.Add(this.FormatSolution(currentBoard));
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
