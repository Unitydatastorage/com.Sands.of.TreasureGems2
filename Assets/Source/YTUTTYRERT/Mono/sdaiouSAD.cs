using System;
using Source.Game;
using UnityEngine;
using VContainer;

namespace Source.UI.Mono
{
    public class sdaiouSAD : UIView
    {
        [Inject] private SDAJKLFKLSA sakjldasljkd;

        private void Awake()
        {
            sakjldasljkd.QWEHJKasdkj += OnWinLevel;
            sakjldasljkd.wqeoiu += Hide;
            Hide();
        }

        private void OnWinLevel()
        {
            Show();
        }

        public void NextLevel()
        {
            sakjldasljkd.NextLevel();
        }

        public void StopGame()
        {
            sakjldasljkd.Menu();
            Hide();
        }
    }
}