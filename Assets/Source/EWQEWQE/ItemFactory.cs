using System.Collections.Generic;
using Source.CellManagement.Mono;
using Source.Level.Mono;
using UnityEngine.Rendering;
using VContainer;
using VContainer.Unity;

namespace Source.CellManagement
{
    public class ItemFactory
    {
        [Inject] private readonly akdjslasdklj m_AkdjslasdkljPrefab;
        [Inject] private readonly IObjectResolver _objectResolver;
        [Inject] private readonly qweuqwieiwqueyqewSA m_QweuqwieiwqueyqewSa;

        private List<akdjslasdklj> _poolItemList = new List<akdjslasdklj>();

        private akdjslasdklj Create()
        {
            akdjslasdklj akdjslasdklj = _objectResolver.Instantiate(m_AkdjslasdkljPrefab, m_QweuqwieiwqueyqewSa.Qwiuhuiwue);
            return akdjslasdklj;
        }

        public akdjslasdklj Get()
        {
            akdjslasdklj findItem = null;
            if (_poolItemList.Count > 0)
            {
                foreach (var poolItem in _poolItemList)
                {
                    if (!poolItem.gameObject.activeSelf)
                    {
                        findItem = poolItem;
                    }
                }
            }

            if (!findItem)
            {
                findItem = Create();
                findItem.qioewqiuoewqiuo += Return;
                _poolItemList.Add(findItem);
            }
            
            findItem.gameObject.SetActive(true);
            findItem.eqwomsdak();
            return findItem;
        }

        private void Return(akdjslasdklj akdjslasdklj)
        {
            akdjslasdklj.gameObject.SetActive(false);
        }
    }
}