using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_N_Queens_Solver
{
    class Board
    {
        private int[,] state;
        private int size;
        private List<int[]> queenLocations;

        public List<int[]> QueenLocations
        {
            get { return this.queenLocations; }
        }

        public Board(int size)
        {
            this.state = new int[size, size];
            this.size = size;
            this.queenLocations = new List<int[]>(size);
        }

        public Board()
        {
        }

        public void PlaceQueen(int[] location)
        {
            int col = location[0];
            int row = location[1];

            this.MarkHorizontal(row);
            this.MarkVertical(col);
            this.MarkDiagonals(col, row);

            this.queenLocations.Add(location);
        }

        public List<int[]> GetFreeSquares(int whichQueen)
        {
            List<int[]> freeSquares = new List<int[]>();
            int searchCol = whichQueen - 1;

            for (int row = 0; row < this.size; row++)
            {
                if (this.state[searchCol, row] == 0)
                {
                    int[] freeSquare = {searchCol, row};
                    freeSquares.Add(freeSquare);
                }
            }

            return freeSquares;
        }

        private void MarkHorizontal(int y)
        {
            for (int col = 0; col < this.size; col++)
            {
                this.state[col, y] = 1;
            }
        }

        private void MarkVertical(int x)
        {
            for (int row = 0; row < this.size; row++)
            {
                this.state[x, row] = 1;
            }
        }

        private void MarkDiagonals(int col, int row)
        {
            for (int searchCol = 0; searchCol < this.size; searchCol++)
            {
                int difference = Math.Abs(col - searchCol);
                int upperRow = row + difference;
                int lowerRow = row - difference;

                if (upperRow < this.size)
                {
                    this.state[searchCol, upperRow] = 1;
                }

                if (lowerRow >= 0)
                {
                    this.state[searchCol, lowerRow] = 1;
                }
            }
        }

        public Board Clone()
        {
            Board cloneBoard = new Board(this.size);

            for (int col = 0; col < this.size; col++)
            {
                for (int row = 0; row < this.size; row++)
                {
                    cloneBoard.state[col, row] = this.state[col, row];
                }
            }

            foreach (int[] location in this.queenLocations)
            {
                cloneBoard.queenLocations.Add(location);
            }

            return cloneBoard;
        }
    }
}