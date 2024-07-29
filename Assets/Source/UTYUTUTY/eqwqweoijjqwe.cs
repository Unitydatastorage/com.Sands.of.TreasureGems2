using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Source.CellManagement;
using Source.CellManagement.Mono;
using Source.Game;
using Source.Level.Mono;
using UnityEngine;
using VContainer;

namespace Source.Level
{
    public class eqwqweoijjqwe
    {
        [Inject] private readonly wiqoeusadoui ajasdknnkad;
        [Inject] private readonly ItemFactory jqwejkqwekjqwe;
        [Inject] private readonly GameSettingsScriptable jkasjnaskd;
        [Inject] private readonly qweuqwieiwqueyqewSA m_QweuqwieiwqueyqewSa;
        private readonly SDAJKLFKLSA wqejkqwejkwqe;

        private Vector2Int wnjqkenjqwk = new Vector2Int(5, 7);
        private List<OIQEJWOI> jqioejwiqeoiwqjoe = new List<OIQEJWOI>();

        private List<OIQEJWOI> ssaijdoasidjoi = new List<OIQEJWOI>();

        [Inject]
        private eqwqweoijjqwe(SDAJKLFKLSA wqejkqwejkwqe)
        {
            this.wqejkqwejkwqe = wqejkqwejkwqe;
            OIQEJWOI.owqieu += CheckMergedCell;
            this.wqejkqwejkwqe.wqeoiu += Generate;
            this.wqejkqwejkwqe.DSAJKsadlkj += RemoveLevel;
        }

        private void Generate()
        {
            if (jqioejwiqeoiwqjoe.Count > 0)
            {
                foreach (var cellView in jqioejwiqeoiwqjoe)
                {
                    cellView.sadkjsdalkljdsa();
                }
            }
            else
            {
                m_QweuqwieiwqueyqewSa.Qwiuhuiwue.position = new Vector2(
                                                    -jkasjnaskd.LevelSize.x / 2f * jkasjnaskd.CellSize.x + jkasjnaskd.CellSize.x/2f,
                                                    -jkasjnaskd.LevelSize.y / 2f * jkasjnaskd.CellSize.y + jkasjnaskd.CellSize.y/2f) + 
                                                jkasjnaskd.LevelPosition;
                for (int i = 0; i < jkasjnaskd.LevelSize.x; i++)
                {
                    for (int j = jkasjnaskd.LevelSize.y; j > 0 ; j--)
                    {
                        if ((Mathf.Abs(i) >= jkasjnaskd.LevelSize.x - jkasjnaskd.BorderCut || 
                            Mathf.Abs(i) <= jkasjnaskd.BorderCut - 1) && 
                            (Mathf.Abs(j) >= jkasjnaskd.LevelSize.y - jkasjnaskd.BorderCut + 1 ||
                            Mathf.Abs(j) <= jkasjnaskd.BorderCut)) continue;
                        Vector2Int position = new Vector2Int(i, j);
                        OIQEJWOI oiqejwoi = ajasdknnkad.Create(position);
                        akdjslasdklj akdjslasdklj = jqwejkqwekjqwe.Get();
                        oiqejwoi.jlksda(akdjslasdklj);
                    
                        jqioejwiqeoiwqjoe.Add(oiqejwoi);
                    }
                }
            }
        }

        private void RemoveLevel()
        {
            for (int i = 0; i < jqioejwiqeoiwqjoe.Count; i++)
            {
                jqioejwiqeoiwqjoe[i].sadkjsdalkljdsa();
                GameObject.Destroy(jqioejwiqeoiwqjoe[i].gameObject);
            }
            jqioejwiqeoiwqjoe.Clear();
        }

        public void UpdateCells()
        {
            MoveItem();
            foreach (var cellView in jqioejwiqeoiwqjoe)
            {
                cellView.MoveItem();
            }
        }
        
        private void CheckMergedCell(OIQEJWOI oiqejwoi)
        {
            ssaijdoasidjoi.Clear();
            Vector2Int vector2Int = oiqejwoi.Asdkl;

            for (int i = vector2Int.x; i < jkasjnaskd.LevelSize.x+1; i++)
            {
                Vector2Int checkPosition = new Vector2Int(i, vector2Int.y);
                var findCell = jqioejwiqeoiwqjoe.FirstOrDefault(_ => checkPosition == _.Asdkl);
                if (findCell && !findCell.IsEmpty && !oiqejwoi.IsEmpty && findCell.Psoiufg.index == oiqejwoi.Psoiufg.index)
                {
                    if (!ssaijdoasidjoi.Contains(findCell))
                    {
                        ssaijdoasidjoi.Add(findCell);
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = vector2Int.x; i >= 0; i--)
            {
                Vector2Int checkPosition = new Vector2Int(i, vector2Int.y);
                var findCell = jqioejwiqeoiwqjoe.FirstOrDefault(_ => checkPosition == _.Asdkl);
                if (findCell && !findCell.IsEmpty && !oiqejwoi.IsEmpty && findCell.Psoiufg.index == oiqejwoi.Psoiufg.index)
                {
                    if (!ssaijdoasidjoi.Contains(findCell))
                    {
                        ssaijdoasidjoi.Add(findCell);
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = vector2Int.y; i < jkasjnaskd.LevelSize.y+1; i++)
            {
                Vector2Int checkPosition = new Vector2Int(vector2Int.x, i);
                var findCell = jqioejwiqeoiwqjoe.FirstOrDefault(_ => checkPosition == _.Asdkl);
                if (findCell && !findCell.IsEmpty && !oiqejwoi.IsEmpty && findCell.Psoiufg.index == oiqejwoi.Psoiufg.index)
                {
                    if (!ssaijdoasidjoi.Contains(findCell))
                    {
                        ssaijdoasidjoi.Add(findCell);
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = vector2Int.y; i >= 0; i--)
            {
                Vector2Int checkPosition = new Vector2Int(vector2Int.x, i);
                var findCell = jqioejwiqeoiwqjoe.FirstOrDefault(_ => checkPosition == _.Asdkl);
                if (findCell && !findCell.IsEmpty && !oiqejwoi.IsEmpty && findCell.Psoiufg.index == oiqejwoi.Psoiufg.index)
                {
                    if (!ssaijdoasidjoi.Contains(findCell))
                    {
                        ssaijdoasidjoi.Add(findCell);
                    }
                }
                else
                {
                    break;
                }
            }

            if (ssaijdoasidjoi.Count > 2)
            {
                if (jkasjnaskd.ByItemScore)
                {
                    wqejkqwejkwqe.AddScore(ssaijdoasidjoi.Count, ssaijdoasidjoi[0].Psoiufg.index);
                }
                else
                {
                    wqejkqwejkwqe.AddScore(ssaijdoasidjoi.Count);
                }
                m_QweuqwieiwqueyqewSa.PlayMerge();
                foreach (var mergedCellView in ssaijdoasidjoi)
                {
                    mergedCellView.sadkjsdalkljdsa();
                }
            }
            else
            {
                oiqejwoi.jkasldjksald();
            }

        }
        
        private void CheckMergedCells()
        {
            foreach (var cellView in jqioejwiqeoiwqjoe)
            {
                CheckMergedCell(cellView);
            }
        }

        private void MoveItem()
        {
            foreach (var cellView in jqioejwiqeoiwqjoe)
            {
                Vector2Int movedPosition = cellView.Asdkl;
                movedPosition.y--;
                OIQEJWOI nextOiqejwoi = jqioejwiqeoiwqjoe.FirstOrDefault(_ => movedPosition == _.Asdkl);
                if (nextOiqejwoi && nextOiqejwoi.IsEmpty)
                {
                    nextOiqejwoi.jlksda(cellView.jasdjlasd());
                    SpawnNewItem();
                }
            }
        }

        private void SpawnNewItem()
        {
            foreach (var cellView in jqioejwiqeoiwqjoe)
            {
                if ((cellView.Asdkl.y >= jkasjnaskd.LevelSize.y - jkasjnaskd.BorderCut - 1 && 
                     (cellView.Asdkl.x >= jkasjnaskd.LevelSize.x - jkasjnaskd.BorderCut ||
                      cellView.Asdkl.x <= jkasjnaskd.BorderCut) ||
                     cellView.Asdkl.y == jkasjnaskd.LevelSize.y) && cellView.IsEmpty)
                {
                    akdjslasdklj akdjslasdklj = jqwejkqwekjqwe.Get();
                    akdjslasdklj.weqiuoqweuioweq(cellView.transform.position+Vector3.up);
                    cellView.jlksda(akdjslasdklj);
                }
            }
        }
    }
}