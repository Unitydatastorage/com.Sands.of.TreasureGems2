using Source.CellManagement.Mono;
using Source.Level.Mono;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Source.CellManagement
{
    public class wiqoeusadoui
    {
        [Inject] private readonly OIQEJWOI m_OiqejwoiPrefab;
        [Inject] private readonly qweuqwieiwqueyqewSA dsaosadhu;
        [Inject] private readonly IObjectResolver asdhuadsuih;

        public OIQEJWOI Create(Vector2Int position)
        {
            OIQEJWOI oiqejwoi = asdhuadsuih.Instantiate(m_OiqejwoiPrefab, dsaosadhu.Qwiuhuiwue);
            oiqejwoi.qwerwqdsdfxcv(position);
            return oiqejwoi;
        }
    }
}