using System.IO;
using System.Media;
using TicTacToe.Properties;

namespace TicTacToe.Utils
{
    class SoundEffectsControl
    {
        public void MoveSound()
        {
            soundPlay(Resources.multimedia_rollover);
        }

        public void MenuClickSound()
        {
            soundPlay(Resources.zapsplat_office_calculator_button_press);
        }

        public void PlayerA()
        {
            soundPlay(Resources.PlayerA);
        }

        public void PlayerB()
        {
            soundPlay(Resources.PlayerB);

        }

        public void Lose()
        {
            soundPlay(Resources.Lose);
        }

        public void Win()
        {
            soundPlay(Resources.Win);
        }
        private void soundPlay(Stream soundeffect){
            using (var soundPlayer = new SoundPlayer(soundeffect))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
  
}
}