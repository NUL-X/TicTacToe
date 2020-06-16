namespace TicTacToe
{
   class Players
    {
        private static bool _isTwoPlayers = true;  // Game Play: vsComputer= false; TwoPlayers = true;
        private static int _level;                 // 1- Easy; 2-Medium ; 3- Hard
       public static void  TwoPlayer()
        { 
            _isTwoPlayers = true;
        }

        public static void OnePlayer(int lvl)
        {
            _isTwoPlayers = false;
            _level = lvl;
        }


        public static int GamePlay()
        {
            return (_isTwoPlayers) ? 2 : 1;
        }

        public static int AI_Level()
        {
            return (!_isTwoPlayers) ? _level : 0;
        }
    }
}
