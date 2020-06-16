namespace TicTacToe.Entities
{
    public static class Structures
    {
        #region Structures

        // type of move user played
        public enum MoveType
        {
            None = 0,
            Ball = -1,
            Cross = 1
        }
        
        // AI difficulty
        public enum AIDifficulty
        {
            Easy = 0,
            Medium = 1,
            Impossible = 2
        }
        
        // Indicates which line to draw when player wins
        public enum LineType
        {
            Vertical = 0,
            Horizontal = 1,
            RightDiagonal = 2,
            LeftDiagonal = 3
        }

        #endregion Structures
    }
}