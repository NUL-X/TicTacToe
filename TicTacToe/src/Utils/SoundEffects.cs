using System.Media;

namespace TicTacToe
{
    class SoundEffectsControl
    {
/*sounds\\multimedia_rollover_044.mp3*/
        public void MoveSound()
        {
         soundPlay(@"sounds//multimedia_rollover.wav");
        }

        public void MenuClickSound()
        {
            soundPlay(@"sounds//zapsplat_office_calculator_button_press.wav");
        }

        public void PlayerA()
        {
            soundPlay(@"sounds//PlayerA.wav");
        }

        public void PlayerB()
        {
            soundPlay(@"sounds//PlayerB.wav");

        }

        public void Lose()
        {
            soundPlay(@"sounds//Lose.wav");
        }

        public void Win()
        {
            soundPlay(@"sounds//Win.wav");
        }
        private void soundPlay(string path){
         using (var soundPlayer = new SoundPlayer(path))
         {
            soundPlayer.Play(); // can also use soundPlayer.PlaySync()
         }
        }
  
}
}