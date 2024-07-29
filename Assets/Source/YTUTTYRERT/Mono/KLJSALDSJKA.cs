using System;
using Source.Game;
using Source.Level.Mono;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.UI.Mono
{
    public class KLJSALDSJKA : MonoBehaviour
    {
        [FormerlySerializedAs("_startLevelButton")] [SerializeField] private Button asakdljasjk;
        [FormerlySerializedAs("_levelNameText")] [SerializeField] private TMP_Text jadkslkjlsda;
        [FormerlySerializedAs("_levelPrefix")] [SerializeField] private string jadklkjsad;
        private SDAJKLFKLSA m_Sdajklfklsa;

        private int _index = 0;

        private void Awake()
        {
            asakdljasjk = GetComponent<Button>();
        }

        public void Init(SDAJKLFKLSA sdajklfklsa, int index)
        {
            m_Sdajklfklsa = sdajklfklsa;
            _index = index;
            jadkslkjlsda.text = $"{jadklkjsad}{_index+1}";
            m_Sdajklfklsa.QWEHJKasdkj += CheckOpen;
            CheckOpen();
            asakdljasjk.onClick.AddListener(StartLevel);
        }

        private void CheckOpen()
        {
            if (_index != 0)
            {
                asakdljasjk.interactable = PlayerPrefs.GetInt("Level_"+_index, 0) == 1;
            }
        }

        private void StartLevel()
        {
            m_Sdajklfklsa.StartLevel(_index);
        }
    }
}