using System;
using System.Collections.Generic;

namespace ChessBoard
{
   
/// <summary>
/// This program takes two user inputs, verifies that they are integers and prompts if not, and uses the numbers to 
/// make a chess table with width of chess board and dimensions of each square.
/// </summary>
    public class Program
    {
        static int squareSize = 0;
        static int boardSize = 0;

        public static void Main()
        {
            //do while loops make sure the program doesnt continue until the user enters valid integer inputs for both sizes
            do
            {
                Console.WriteLine("Enter Square size: ");
                string squareInput = Console.ReadLine();
                Program.squareSize = InputTester.TestInput(squareInput);
            } while (squareSize == 0);


            do
            {
                Console.WriteLine("Enter Board size: ");
                string boardInput = Console.ReadLine();
                Program.boardSize = InputTester.TestInput(boardInput);
            } while (boardSize == 0);
            

            ChessBoardMaker board = new ChessBoardMaker();
            board.GetBoard(squareSize, boardSize);
            Console.ReadLine();
        }

    }



   


}
