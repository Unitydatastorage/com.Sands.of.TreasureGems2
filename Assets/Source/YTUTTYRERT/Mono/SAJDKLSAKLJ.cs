using Source.Game;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.UI.Mono
{
    public class SAJDKLSAKLJ : MonoBehaviour
    {
        [FormerlySerializedAs("_onImage")] [SerializeField] private Image qwejlk;
        [FormerlySerializedAs("_offImage")] [SerializeField] private Image jqlkew;
        [FormerlySerializedAs("_key")] [SerializeField] private string xczlk;
        [FormerlySerializedAs("_gameSettingsScriptable")] [SerializeField] private GameSettingsScriptable wqelkj;
        
        private Toggle _toggle;
        
        private void Awake()
        {
            _toggle = GetComponent<Toggle>();
            _toggle.onValueChanged.AddListener(ValueChange);
            _toggle.isOn = PlayerPrefs.GetInt(xczlk, 1) == 1;
            ValueChange(_toggle.isOn);
        }

        public void ValueChange(bool value)
        {
            qwejlk.enabled = value;
            jqlkew.enabled = !value;
            PlayerPrefs.SetInt(xczlk, value ? 1 : 0);
            wqelkj.TimerEnable = value;
        }

        private void OnEnable()
        {
            _toggle.isOn = PlayerPrefs.GetInt(xczlk, 1) == 1;
        }
    }
}