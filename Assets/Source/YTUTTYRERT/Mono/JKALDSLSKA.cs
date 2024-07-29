using Source.Game;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VContainer;

namespace Source.UI.Mono
{
    public class JKALDSLSKA : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA jlsad;

        [FormerlySerializedAs("_pointsName")] [SerializeField] private string jksakjlda;
        [FormerlySerializedAs("_pointsSlider")] [SerializeField] private Slider qwejkewqklj;
        
        private void Awake()
        {
            jlsad.DSAKDJLasdljk += OnScoreUpdate;
        }
        
        private void OnScoreUpdate(int val, int maxVal)
        {
            if (qwejkewqklj)
            {
                qwejkewqklj.value = (float)val / maxVal;
            }
            
        }
    }
}