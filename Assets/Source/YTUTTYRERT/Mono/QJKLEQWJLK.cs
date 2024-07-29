using Source.Game;
using UnityEngine;
using VContainer;

namespace Source.UI.Mono
{
    public class QJKLEQWJLK : UIView
    {
        [Inject] private SDAJKLFKLSA JKSADKLSA;
        
        private void Awake()
        {
            JKSADKLSA.xzcljkAS += OnLoseLevel;
            JKSADKLSA.wqeoiu += Hide;
            Hide();
        }

        private void OnLoseLevel()
        {
            Show();
        }

        public void Restart()
        {
            JKSADKLSA.Restart();
        }
        
        public void StopGame()
        {
            JKSADKLSA.Menu();
            Hide();
        }
    }
}