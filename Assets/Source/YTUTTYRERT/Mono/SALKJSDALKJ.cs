using Source.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

namespace Source.UI.Mono
{
    public class SALKJSDALKJ : MonoBehaviour
    {
        [Inject] private SDAJKLFKLSA adljksadlk;

        [FormerlySerializedAs("_levelText")] [SerializeField] private string jasdjklas;
        [FormerlySerializedAs("_levelName")] [SerializeField] private TMP_Text jlkeqwlkjweq;
        
        private void Awake()
        {
            adljksadlk.ASKJLDasdjkl += OnLevelUpdate;
        }

        private void OnLevelUpdate(int val)
        {
            if (jlkeqwlkjweq)
            {
                jlkeqwlkjweq.text = $"{jasdjklas} {val}";
            }
        }
    }
}