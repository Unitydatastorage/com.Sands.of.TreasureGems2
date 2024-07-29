using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.UI.Mono
{
    public class JSAKLJDKALS : MonoBehaviour
    {
        [FormerlySerializedAs("itemImage")] [SerializeField] private Image jklsadkjlsa;
        [FormerlySerializedAs("scoreText")] [SerializeField] private TMP_Text jkalkjasd;


        public void SetSprite(Sprite sprite)
        {
            jklsadkjlsa.sprite = sprite;
        }
        
        public void UpdateCounter(int value, int maxValue)
        {
            jkalkjasd.text = $"{value}/{maxValue}";
        }
    }
}