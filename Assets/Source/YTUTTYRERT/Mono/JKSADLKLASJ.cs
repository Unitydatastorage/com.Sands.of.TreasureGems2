using System;
using Source.Game;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

namespace Source.UI.Mono
{
    public class JKSADLKLASJ : MonoBehaviour
    {
        private SDAJKLFKLSA jsdalkjds;
        private GameSettingsScriptable jsdakldlka;
        
        [FormerlySerializedAs("_itemCounterUI")] [SerializeField] private JSAKLJDKALS jsakljdkals;
        private JSAKLJDKALS[] sdjak;

        [Inject]
        private void Container(SDAJKLFKLSA sdajklfklsa, GameSettingsScriptable gameSettingsScriptable)
        {
            jsdalkjds = sdajklfklsa;
            jsdakldlka = gameSettingsScriptable;
            jsdalkjds.wqeoiu += OnStartLevel;
            jsdalkjds.qewjSADLJK += OnItemScoreUpdate;
        }

        private void OnItemScoreUpdate(int val, int maxVal, int id)
        {
            if (sdjak != null && sdjak.Length > id)
            {
                sdjak[id].UpdateCounter(val, maxVal);
            }
        }

        private void OnStartLevel()
        {
            if (sdjak != null && sdjak.Length > 0)
            {
                for (int i = 0; i < jsdakldlka.EggSprites.Length; i++)
                {
                    Destroy(sdjak[i].gameObject);
                }
            }
            sdjak = new JSAKLJDKALS[jsdakldlka.EggSprites.Length];
            
            for (int i = 0; i < jsdakldlka.EggSprites.Length; i++)
            {
                Debug.Log("Score Created!" + sdjak.Length);
                sdjak[i] = Instantiate(jsakljdkals, transform);
                sdjak[i].SetSprite(jsdakldlka.EggSprites[i]);
            }
        }
    }
}