using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.UI.Mono
{
    public class JKLQWEQL : MonoBehaviour
    {
        [FormerlySerializedAs("_policeConfirmUI")] [SerializeField] private DSAJKDKLAS sajdkllkdjsa;
        [FormerlySerializedAs("_mainMenu")] [SerializeField] private jkewqkljqw jkldasaklj;
        [FormerlySerializedAs("_UIViews")] [SerializeField] private UIView[] wqejwqkwlkje;

        private void Start()
        {
            foreach (var variUIView in wqejwqkwlkje)
            {
                variUIView.Hide();
            }
            var policy = PlayerPrefs.GetInt("Policy", 0);
            if (policy == 0)
            {
                sajdkllkdjsa.Show();
            }
            else
            {
                jkldasaklj.Show();
            }
        }
    }
}