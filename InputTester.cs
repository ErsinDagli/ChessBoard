using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    /// <summary>
    /// This static class has one method that tests the user input via console. It makes sure that the user ONLY enters integer values 
    /// for square size and board size. If not then it prompts the user to do so!
    /// </summary>
    public static class InputTester
    {

        public static int TestInput(string s)
        {
            if (int.TryParse(s, out int inputInteger) && inputInteger > 0)
            {

                return inputInteger;

            }
            else
            {
                Console.WriteLine("Please enter a positive integer!");


                return 0;
            }




        }
    }
}
