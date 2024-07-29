using Source.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VContainer;

namespace Source.UI.Mono
{
    public class SKJLADDSKJAL : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA jskadlsd;
        
        [FormerlySerializedAs("_timerText")] [SerializeField] private TMP_Text jkadslk;
        [FormerlySerializedAs("_levelName")] [SerializeField] private TMP_Text ewqiuoe;
        [FormerlySerializedAs("_timerSlider")] [SerializeField] private Slider xcxmz;

        private void Awake()
        {
            jskadlsd.SADLKJasdlkj += OnTimerUpdate;
            jskadlsd.ASKJLDasdjkl += OnLevelUpdate;
        }

        private void OnLevelUpdate(int val)
        {
            if (ewqiuoe)
            {
                ewqiuoe.text = $"Level: {val}";
            }
        }

        private void OnTimerUpdate(float val)
        {
            if (jkadslk)
            {
                jkadslk.text = $"Timer: {Mathf.FloorToInt(val/60f)}m.{Mathf.RoundToInt(val%60f)}s.";
            }

            if (xcxmz)
            {
                xcxmz.value = val / jskadlsd.LevelTime;
            }
            
        }
    }
}