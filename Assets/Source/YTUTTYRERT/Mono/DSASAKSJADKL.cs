using System;
using Source.Audio.Mono;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.UI.Mono
{
    public class DSASAKSJADKL : MonoBehaviour
    {

        [FormerlySerializedAs("_onImage")] [SerializeField] private Image kldjaskjdsal;
        [FormerlySerializedAs("_offImage")] [SerializeField] private Image jkaldkjasld;
        [FormerlySerializedAs("_key")] [SerializeField] private string jksalskad;
        [FormerlySerializedAs("_musicManagers")] [SerializeField] private MusicManager[] jsadlkjdsa;

        private Toggle welkwqjlk;

        private void Awake()
        {
            welkwqjlk = GetComponent<Toggle>();
            welkwqjlk.onValueChanged.AddListener(kaldskjldsa);
            welkwqjlk.isOn = PlayerPrefs.GetInt(jksalskad, 1) == 1;
            kaldskjldsa(welkwqjlk.isOn);
        }

        public void kaldskjldsa(bool value)
        {
            kldjaskjdsal.enabled = value;
            jkaldkjasld.enabled = !value;
            foreach (var musicManager in jsadlkjdsa)
            {
                musicManager.OnOffMusic(value);
            }
            
        }

        private void OnEnable()
        {
            welkwqjlk.isOn = PlayerPrefs.GetInt(jksalskad, 1) == 1;
        }
    }
}