using Source.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

namespace Source.UI.Mono
{
    public class ASDJKLSAJKDL : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA jksdajhaskd;

        [FormerlySerializedAs("_scoreName")] [SerializeField] private string ldjsaid;
        [FormerlySerializedAs("_scoreText")] [SerializeField] private TMP_Text sjdkladkjl;
        
        private void Awake()
        {
            jksdajhaskd.DSAKDJLasdljk += OnScoreUpdate;
        }

        private void OnScoreUpdate(int val, int maxVal)
        {
            sjdkladkjl.text = $"{ldjsaid} {val}/{maxVal}";
        }
    }
}