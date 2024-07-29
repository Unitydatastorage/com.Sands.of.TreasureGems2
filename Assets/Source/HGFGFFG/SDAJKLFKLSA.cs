using System;
using Source.Level.Mono;
using UnityEngine;
using VContainer;
using Random = UnityEngine.Random;

namespace Source.Game
{
    public class SDAJKLFKLSA
    {
        [Inject] private readonly GameSettingsScriptable sahdjsahjk;
        private LevelScriptable kjleqjklewq;
        private int jkqwleewjkql;
        public int Jkqwleewjkql => jkqwleewjkql;

        private float wqeouioqwi;
        public float LevelTime => kjleqjklewq.Duration;
        private int xzcio;
        private int[] eqwt;
        private int[] zxcjk;

        private bool woqei = false;
        public bool Woqei => woqei;

        public Action wqeoiu, xzcljkAS, QWEHJKasdkj, DSAJKsadlkj;

        public Action<int, int> DSAKDJLasdljk;
        public Action<int, int, int> qewjSADLJK;
        public Action<float> SADLKJasdlkj;
        public Action<int> ASKJLDasdjkl;


        public void UpdateTimer()
        {
            if (woqei && sahdjsahjk.TimerEnable)
            {
                wqeouioqwi = Mathf.Clamp(wqeouioqwi - Time.deltaTime, 0, kjleqjklewq.Duration);
                SADLKJasdlkj?.Invoke(wqeouioqwi);
                if (wqeouioqwi == 0)
                {
                    xzcljkAS?.Invoke();
                    woqei = false;
                    UpdateAllData();
                }
            }
        }

        public void AddScore(int value)
        {
            xzcio = Mathf.Clamp(xzcio + value, 0, kjleqjklewq.MaxScore);
            DSAKDJLasdljk?.Invoke(xzcio, kjleqjklewq.MaxScore);
            if (xzcio == kjleqjklewq.MaxScore)
            {
                PlayerPrefs.SetInt("Level_"+(jkqwleewjkql+1), 1);
                QWEHJKasdkj?.Invoke();
                woqei = false;
                UpdateAllData();
            }
        }
        
        public void AddScore(int value, int id)
        {
            if (eqwt.Length < id) return;
            
            zxcjk[id] = Mathf.Clamp(zxcjk[id] + value, 0, eqwt[id]);
            Debug.Log(zxcjk[id] + "/" + eqwt[id]);
            qewjSADLJK?.Invoke(zxcjk[id], eqwt[id], id);
            bool isComplete = true;
            for (int i = 0; i < sahdjsahjk.EggSprites.Length; i++)
            {
                if (zxcjk[i] != eqwt[i])
                {
                    isComplete = false;
                }
            }
            if (isComplete)
            {
                PlayerPrefs.SetInt("Level_"+(jkqwleewjkql+1), 1);
                QWEHJKasdkj?.Invoke();
                woqei = false;
                UpdateAllData();
            }
        }
        
        public void StartLevel(int index)
        {
            jkqwleewjkql = index;
            kjleqjklewq = sahdjsahjk.LevelScriptables[jkqwleewjkql];
            Restart();
        }

        public void NextLevel()
        {
            StartLevel(Mathf.Clamp(jkqwleewjkql+1, 0, sahdjsahjk.LevelScriptables.Length));
        }

        public void Pause()
        {
            woqei = false;
        }

        public void Resume()
        {
            woqei = true;
        }

        public void Restart()
        {
            wqeouioqwi = kjleqjklewq.Duration;
            if (sahdjsahjk.ByItemScore)
            {
                eqwt = new int[sahdjsahjk.EggSprites.Length];
                zxcjk = new int[sahdjsahjk.EggSprites.Length];
                for (int i = 0; i < sahdjsahjk.EggSprites.Length; i++)
                {
                    eqwt[i] = Random.Range(kjleqjklewq.MinScore, kjleqjklewq.MaxScore);
                }
            }
            else
            {
                xzcio = 0;
            }
            
            woqei = true;
            wqeoiu?.Invoke();
            UpdateAllData();
        }

        private void UpdateAllData()
        {
            SADLKJasdlkj?.Invoke(wqeouioqwi);
            if (sahdjsahjk.ByItemScore)
            {
                for (int i = 0; i < sahdjsahjk.EggSprites.Length; i++)
                {
                    qewjSADLJK?.Invoke(zxcjk[i], eqwt[i], i);
                }
            }
            else
            {
                DSAKDJLasdljk?.Invoke(xzcio, kjleqjklewq.MaxScore);
            }

            ASKJLDasdjkl?.Invoke(jkqwleewjkql+1);
        }

        public void Menu()
        {
            woqei = false;
            DSAJKsadlkj?.Invoke();
        }
    }
}