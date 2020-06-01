using System;

namespace TicTacToe.Utils
{
    public static class StringUtils
    {
        public static int Asc(string character)
        {
            // VB.NET ASC function

            var asciiEncoding = new System.Text.ASCIIEncoding();
            switch (character.Length)
            {
                case 1:
                {
                    var intAsciiCode = (int) asciiEncoding.GetBytes(character)[0];
                    return (intAsciiCode);
                }
                default:
                    throw new ApplicationException("Character is not valid.");
            }
        }
    }
}