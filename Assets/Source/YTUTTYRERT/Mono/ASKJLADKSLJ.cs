using System;
using Source.Game;
using Source.Level.Mono;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.Serialization;
using VContainer;

namespace Source.UI.Mono
{
    public class ASKJLADKSLJ : UIView
    {
        [FormerlySerializedAs("_levelPanel")] [SerializeField] private Transform adjklsadlkj;
        [FormerlySerializedAs("_levelButtonPrefab")] [SerializeField] private KLJSALDSJKA kljsaldsjkaPrefab;

        [Inject] private GameSettingsScriptable jadslkj;
        [Inject] private SDAJKLFKLSA jklsadj;

        private void Awake()
        {
            jklsadj.wqeoiu += Hide;
            int index = 0;
            foreach (var levelScriptable in jadslkj.LevelScriptables)
            {
                KLJSALDSJKA newKljsaldsjka = Instantiate(kljsaldsjkaPrefab, adjklsadlkj);
                newKljsaldsjka.Init(jklsadj, index);
                index++;
            }
        }
    }
}