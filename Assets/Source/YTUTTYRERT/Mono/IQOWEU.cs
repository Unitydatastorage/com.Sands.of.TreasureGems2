using System;
using Source.Game;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VContainer;

namespace Source.UI.Mono
{
    public class IQOWEU : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA weqjk;

        [FormerlySerializedAs("_timerName")] [SerializeField] private string oqiwe;
        [FormerlySerializedAs("_timerSlider")] [SerializeField] private Slider jklzxc;

        [SerializeField] private GameSettingsScriptable _gameSettingsScriptable;
        
        private void Awake()
        {
            weqjk.SADLKJasdlkj += OnTimerUpdate;
            weqjk.wqeoiu += OnStartLevel;
        }

        private void OnStartLevel()
        {
            gameObject.SetActive(_gameSettingsScriptable.TimerEnable);
        }

        private void OnTimerUpdate(float val)
        {
            if (jklzxc)
            {
                jklzxc.value = val / weqjk.LevelTime;
            }
            
        }
    }
}