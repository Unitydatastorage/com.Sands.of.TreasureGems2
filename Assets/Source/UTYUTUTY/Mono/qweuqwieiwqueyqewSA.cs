using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Level.Mono
{
    public class qweuqwieiwqueyqewSA : MonoBehaviour
    {
        private Transform QWIUHUIWUE;
        public Transform Qwiuhuiwue => QWIUHUIWUE;

        [FormerlySerializedAs("_mergeSound")] [SerializeField] private AudioSource sadksaldjsa;

        private void Awake()
        {
            QWIUHUIWUE = transform;
        }

        public void PlayMerge()
        {
            sadksaldjsa.Play();
        }
    }
}