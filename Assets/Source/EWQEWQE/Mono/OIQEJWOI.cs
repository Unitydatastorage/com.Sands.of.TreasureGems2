using System;
using System.Collections;
using Source.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using VContainer;

namespace Source.CellManagement.Mono
{
    public class OIQEJWOI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler
    {
        private Vector2Int asdkl;
        public Vector2Int Asdkl => asdkl;

        private Transform oqwiepuwqisd;
        public Transform Oqwiepuwqisd => oqwiepuwqisd;
        private SpriteRenderer oiqejiowqe;
        private Collider2D jiqwiojeqpw;
        
        private akdjslasdklj psoiufg;
        public akdjslasdklj Psoiufg => psoiufg;
        private static bool qweuioqwoui = true;
        public bool IsEmpty => !psoiufg;
        private OIQEJWOI oewoiqu;

        public static Action<OIQEJWOI> owqieu;

        [Inject] private GameSettingsScriptable njdkfsvv;

        private void Awake()
        {
            oqwiepuwqisd = transform;
            oiqejiowqe = GetComponent<SpriteRenderer>();
            jiqwiojeqpw = GetComponent<Collider2D>();
            oiqejiowqe.sprite = njdkfsvv.CellSprite;
        }
        
        public void jlksda(akdjslasdklj akdjslasdklj)
        {
            psoiufg = akdjslasdklj;
        }
        
        public void qwerwqdsdfxcv(Vector2Int position)
        {
            asdkl = position;
            oqwiepuwqisd.localPosition = position * oiqweiwuqoe();
        }

        private Vector2 oiqweiwuqoe()
        {
            return oiqejiowqe.bounds.size;
        }
        
        public void MoveItem()
        {
            if (psoiufg)
            {
                psoiufg.asidoadsioj(oqwiepuwqisd.position);
            }
        }
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("Begin");
            jiqwiojeqpw.enabled = false;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            jiqwiojeqpw.enabled = true;
        }

        public akdjslasdklj jasdjlasd()
        {
            var currentItem = psoiufg;
            psoiufg = null;
            return currentItem;
        }

        private IEnumerator SwapCell(OIQEJWOI swapOiqejwoi)
        {
            oewoiqu = swapOiqejwoi;
            (psoiufg, swapOiqejwoi.psoiufg) = (swapOiqejwoi.psoiufg, psoiufg);
            qweuioqwoui = false;
            yield return new WaitWhile(() => psoiufg.Wqeoiueiowuq);
            yield return new WaitForSeconds(0.2f);
            qweuioqwoui = true;
            owqieu?.Invoke(this);
            //OnSwapItem?.Invoke(swapCellView);
        }
        
        private IEnumerator SwapCell()
        {
            (psoiufg, oewoiqu.psoiufg) = (oewoiqu.psoiufg, psoiufg);
            qweuioqwoui = false;
            yield return new WaitWhile(() => psoiufg.Wqeoiueiowuq);
            yield return new WaitForSeconds(0.2f);
            qweuioqwoui = true;
            oewoiqu = null;
        }

        public void jkasldjksald()
        {
            StartCoroutine(SwapCell());
        }

        public void sadkjsdalkljdsa()
        {
            psoiufg.weqpipieoqwpiowe();
            psoiufg = null;
        }

        public void OnDrag(PointerEventData eventData)
        {
            
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (!qweuioqwoui) return;
            if (eventData.pointerDrag && eventData.pointerDrag.TryGetComponent(out OIQEJWOI dragCellView))
            {
                
                int x = Mathf.Abs(asdkl.x - dragCellView.asdkl.x);
                int y = Mathf.Abs(asdkl.y - dragCellView.asdkl.y);
                if ((x == 1 || y == 1) && x + y == 1)
                {
                    StartCoroutine(SwapCell(dragCellView));
                }
            }
        }
    }
    
}