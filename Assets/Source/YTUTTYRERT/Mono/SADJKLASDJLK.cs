using Source.Audio.Mono;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.UI.Mono
{
    public class SADJKLASDJLK : MonoBehaviour
    {
        [FormerlySerializedAs("_key")] [SerializeField] private string dsadjklas;
        [FormerlySerializedAs("_musicManager")] [SerializeField] private MusicManager jhasdjask;

        private Slider jksladjkldsa;

        private void Awake()
        {
            jksladjkldsa = GetComponent<Slider>();
            jksladjkldsa.onValueChanged.AddListener(ValueChange);
            jksladjkldsa.value = PlayerPrefs.GetFloat(dsadjklas, 1f);
            ValueChange(jksladjkldsa.value);
        }

        public void ValueChange(float value)
        {
            jhasdjask.SlideMusic(value);
        }

        private void OnEnable()
        {
            jksladjkldsa.value = PlayerPrefs.GetFloat(dsadjklas, 1f);
        }
    }
}