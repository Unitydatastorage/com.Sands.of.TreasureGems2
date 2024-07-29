using Source.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VContainer;

namespace Source.UI.Mono
{
    public enum TimerType
    {
        MinSec,
        Sec,
    }

    public class KSJLADJKLSA : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA sdajkl;

        [FormerlySerializedAs("_timerName")] [SerializeField] private string jaklsdl;
        [FormerlySerializedAs("_timerText")] [SerializeField] private TMP_Text qjklwelkq;
        [FormerlySerializedAs("_timerType")] [SerializeField] private TimerType ajskdlsa;

        private void Awake()
        {
            sdajkl.SADLKJasdlkj += OnTimerUpdate;
        }
        
        private void OnTimerUpdate(float val)
        {
            if (qjklwelkq)
            {
                switch (ajskdlsa)
                {
                    case TimerType.MinSec:
                        qjklwelkq.text = $"{jaklsdl} {Mathf.FloorToInt(val/60f)}m.{Mathf.RoundToInt(val%60f)}s.";
                        break;
                    case TimerType.Sec:
                        qjklwelkq.text = $"{jaklsdl} {Mathf.RoundToInt(val)}sec.";
                        break;
                }
                
            }

        }
    }
}