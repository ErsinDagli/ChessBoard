using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    /// <summary>
    /// This class creates the chess board. It uses the parameters provided by the user via the console input
    /// The class has methods to create rows and columns
    /// </summary>
    class ChessBoardMaker
    {
        static string column = "|";
        static string row = "-";
        static string corner = "+";
        static string hash = "#";


        /// <summary>
        /// This class makes the chess board using using parameters provided via console user input
        /// </summary>
        /// <param name="squaresize"></param>
        /// <param name="boardsize"></param>
        public void GetBoard(int squaresize, int boardsize)
        {

            //start with a top wall to the chess board
            Console.WriteLine(string.Join(" ", GetEdges(squaresize, boardsize).ToArray()));


            for (int k = 0; k < boardsize; k++)
            {
                //first condition creates top row
                if (k % 2 == 0)
                {
                    
                    for (int i = 0; i < squaresize; i++)
                    {

                        Console.WriteLine(string.Join(" ", GetHashTopRow(squaresize, boardsize).ToArray()));


                    }
                    //create a wall between two rows of the chessboard
                    Console.WriteLine(string.Join(" ", GetEdges(squaresize, boardsize).ToArray()));
                }
                //else condition creates bottom row
                else
                {
                    for (int i = 0; i < squaresize; i++)
                    {
                        Console.WriteLine(string.Join(" ", GetHashBottomRow(squaresize, boardsize).ToArray()));

                    }
                    Console.WriteLine(string.Join(" ", GetEdges(squaresize, boardsize).ToArray()));
                }




            }


        }

        /// <summary>
        /// This method again uses parameters provided by the user in the console input to create horizontal lines or the horizontal walls of the chessboard
        /// </summary>
        /// <param name="squaresize"></param>
        /// <param name="boardsize"></param>
        /// <returns></returns>
        static List<string> GetEdges(int squaresize, int boardsize)
        {
            List<string> hor = new List<string>();
            for (int i = 0; i < (boardsize); i++)
            {
                hor.Add(corner);
                for (int j = 0; j < squaresize; j++)
                {
                    hor.Add(row);
                }


                if (i == boardsize - 1)
                {
                    hor.Add(corner);

                }

            }

            return hor;
        }

        /// <summary>
        /// This method uses the parameters to create the row of the chess board which starts with dark square first then empty square etc.
        /// </summary>
        /// <param name="squaresize"></param>
        /// <param name="boardsize"></param>
        /// <returns></returns>
        static List<string> GetHashTopRow(int squaresize, int boardsize)
        {
            List<string> vert = new List<string>();

            vert.Add(column);

            for (int k = 0; k < boardsize; k++)
            {
                if (k % 2 == 0)
                {



                    for (int j = 0; j < squaresize; j++)
                    {

                        vert.Add(hash);

                    }
                    vert.Add(column);




                }
                else
                {
                    for (int j = 0; j < squaresize; j++)
                    {

                        vert.Add(" ");
                    }
                    vert.Add(column);

                }


            }
            return vert;

        }


        /// <summary>
        /// This method uses parameters to make row of the chess board that starts with empty square first then dark square etc
        /// </summary>
        /// <param name="squaresize"></param>
        /// <param name="boardsize"></param>
        /// <returns></returns>
        static List<string> GetHashBottomRow(int squaresize, int boardsize)
        {
            List<string> vert = new List<string>();

            vert.Add(column);


            for (int k = 0; k < boardsize; k++)
            {
                if (k % 2 == 0)
                {



                    for (int j = 0; j < squaresize; j++)
                    {

                        vert.Add(" ");

                    }
                    vert.Add(column);




                }
                else
                {
                    for (int j = 0; j < squaresize; j++)
                    {

                        vert.Add(hash);
                    }
                    vert.Add(column);

                }


            }
            return vert;

        }


    }
}
